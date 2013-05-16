/*
 * Copyright 2013 Preact / Preact.io
 *
 * Author(s):
 *  Christopher Gooley / Preact (gooley@preact.io)
 *  Billy Coover / Preact (gooley@preact.io)
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

using System.IO;
using System.Net;
using System.Web;
using System.Security.Cryptography;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Preact
{
    internal static class Helpers
    {
        private static string UserAgent = "Preact Client .NET v0.3";
        public static string SourceApiVersion = "preact-dotnet:0.3";

        public static byte[] GetPostData(List<KeyValuePair<string, string>> items)
        {
            string postData = "";
            List<string> vals = new List<string>();
            foreach (var item in items)
            {
                vals.Add(string.Format("{0}={1}", HttpUtility.UrlEncode(item.Key), HttpUtility.UrlEncode(item.Value)));
            }
            postData = string.Join("&", vals.ToArray());

            ASCIIEncoding encoding = new ASCIIEncoding();
            return encoding.GetBytes(postData);
        }

        public static List<KeyValuePair<string, string>> BuildFormData(JObject obj, string parent = null)
        {
            List<KeyValuePair<string, string>> items = new List<KeyValuePair<string, string>>();
            
            foreach (var v in obj.Properties())
            {
                if (v.Value.Type == JTokenType.Array)
                {
                    int index = 0;
                    foreach (var vv in v.Value)
                    {
                        JObject joInside = vv as JObject;
                        if (joInside != null)
                        {
                            items.AddRange(BuildFormData(joInside, GetFormDataKey(parent + "[" + v.Name + "]", index.ToString())));
                        }

                        index++;
                    }
                } 
                else if (v.Value.HasValues)
                {
                    foreach (var vv in v.Children())
                    {
                        JObject joInside = vv as JObject;
                        if (joInside != null)
                        {
                            items.AddRange(BuildFormData(joInside, GetFormDataKey(parent, v.Name)));
                        }
                    }
                }
                else if (v.Value.Type != JTokenType.Null && v.Value.Type != JTokenType.None)
                {
                    items.Add(new KeyValuePair<string, string>(GetFormDataKey(parent, v.Name), v.Value.ToString()));
                }
            }

            return items;
        }

        public static string GetFormDataKey(string parent, string key)
        {
            if (string.IsNullOrEmpty(parent))
            {
                return key;
            }
            else
            {
                return string.Format("{0}[{1}]", parent, key);
            }
        }

        public static void SendData(string projectCode, string projectApiSecret, string url, string method, JObject obj)
        {
            SendData(projectCode, projectApiSecret, url, method, BuildFormData(obj));
        }

        // POST or PUT or something
        public static void SendData(string projectCode, string projectApiSecret, string url, string method, List<KeyValuePair<string, string>> items)
        {
            new ApiLogger(projectCode, projectApiSecret, url, method, items);
        }

        private class ApiLogger
        {
            public string Url { get; set; }
            public string Method { get; set; }
            public string Code { get; set; }
            public string Secret { get; set; }
            public List<KeyValuePair<string, string>> Items { get; set; }

            private HttpWebRequest req;

            const int DefaultTimeout = 10 * 1000; // 10 second timeout 

            // Abort the request if the timer fires. 
            private static void TimeoutCallback(object state, bool timedOut)
            {
                if (timedOut)
                {
                    HttpWebRequest request = state as HttpWebRequest;
                    if (request != null)
                    {
                        request.Abort();
                    }
                }
            }

            public ApiLogger(string projectCode, string projectApiSecret, string url, string method, List<KeyValuePair<string, string>> items)
            {
                Url = url;
                Method = method;
                Items = items;
                Code = projectCode;
                Secret = projectApiSecret;
                Send();
            }

            public void Send()
            {
                req = (HttpWebRequest)WebRequest.Create(this.Url);
                req.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(Code + ":" + Secret));
                req.Method = this.Method;
                req.ContentType = "application/x-www-form-urlencoded";
                req.Accept = "text/javascript";
                req.UserAgent = UserAgent;
                var asyncResult = req.BeginGetRequestStream(this.RequestCallback, req);

                // implement a timeout
                ThreadPool.RegisterWaitForSingleObject(asyncResult.AsyncWaitHandle, new WaitOrTimerCallback(TimeoutCallback), req, DefaultTimeout, true);
            }

            private void RequestCallback(IAsyncResult asyncResult)
            {
                try
                {
                    var data = GetPostData(Items);

                    Stream newStream = req.EndGetRequestStream(asyncResult);
                    newStream.Write(data, 0, data.Length);
                    newStream.Close();

                    var result = req.BeginGetResponse(this.ResponseCallback, req);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            private void ResponseCallback(IAsyncResult asyncResult)
            {
                try
                {
                    WebResponse response = req.EndGetResponse(asyncResult);      
                    response.Close();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally { }
            }
        }
    }
}
