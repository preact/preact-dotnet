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

using System.IO;
using System.Net;
using System.Web;
using System.Security.Cryptography;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Preact
{
    public class Api
    {
        private static string api_endpoint_events = "https://api.preact.io/api/v2/events";
        private static string api_endpoint_metrics = "https://api.preact.io/api/v2/metrics";
        private static Encoding encoding = Encoding.UTF8;

        private string ProjectCode { get; set; }
        private string ProjectApiSecret { get; set; }

        #region Constructors
        public Api() :
            this(System.Configuration.ConfigurationManager.AppSettings["PreactProjectCode"],
                System.Configuration.ConfigurationManager.AppSettings["PreactProjectApiSecret"]) { }

        public Api(string projectCode, string secretKey)
        {
            if (string.IsNullOrEmpty(projectCode) || string.IsNullOrEmpty(secretKey))
                throw new ArgumentException("Missing ProjectCode or ProjectApiSecret");

            ProjectCode = projectCode;
            ProjectApiSecret = secretKey;
        }
        #endregion

        #region Static Helpers
        private static Api _client;

        public static Api Client
        {
            get
            {
                if (_client == null) { _client = new Api(); }
                return _client;
            }
        }
        #endregion

        public void LogEvent(ActionEventCreateRequest request)
        {
            JObject param = JObject.FromObject(request);
            Helpers.SendData(ProjectCode, ProjectApiSecret, api_endpoint_events, "POST", param);
            
        }

        public void LogBackgroundSignal(BackgroundSignalRequest request)
        {
            JObject param = JObject.FromObject(request);
            Helpers.SendData(ProjectCode, ProjectApiSecret, api_endpoint_metrics, "POST", param);
        }


    }
}
