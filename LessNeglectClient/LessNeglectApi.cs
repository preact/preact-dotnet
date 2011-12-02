﻿/*
 * Copyright 2011 Christopher Gooley / LessNeglect.com
 *
 * Author(s):
 *  Christopher Gooley / LessNeglect (gooley@lessneglect.com)
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

using System.IO;
using System.Net;
using System.Web;
using System.Security.Cryptography;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace LessNeglect
{
    public class LessNeglectApi
    {
        private static string api_endpoint = "http://beta.lessneglect.com/api/v1";
        //private static string api_endpoint = "http://test.lessneglect.com:4000/api/v1";
        private static Encoding encoding = Encoding.UTF8;

        private string ProjectCode { get; set; }
        private string ProjectApiSecret { get; set; }

        #region Constructors
        public LessNeglectApi() :
            this(System.Configuration.ConfigurationManager.AppSettings["LessNeglectProjectCode"],
                System.Configuration.ConfigurationManager.AppSettings["LessNeglectProjectApiSecret"]) { }

        public LessNeglectApi(string code, string secret)
        {
            if (string.IsNullOrEmpty(code) || string.IsNullOrEmpty(secret))
                throw new ArgumentException("Missing ProjectCode or ProjectApiSecret");

            ProjectCode = code;
            ProjectApiSecret = secret;
        }
        #endregion

        #region Static helpers

        private static LessNeglectApi _client;
        public static LessNeglectApi Client
        {
            get
            {
                if (_client == null) { _client = new LessNeglectApi(); }
                return _client;
            }
        }
        #endregion

        public CoreResponse CreateMessage(MessageCreateRequest message)
        {
            // sign the request 
            message.SignRequest(ProjectCode, ProjectApiSecret);

            string url = String.Format("{0}/messages", api_endpoint);
            return new CoreResponse(Helpers.GetApiResponse(url, "POST", JObject.FromObject(message)));
        }

    }



}