/*
 * Copyright 2014 Preact / Preact.io
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
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Preact
{
    [JsonObject(MemberSerialization.OptIn)]
    public class ActionEvent
    {
        /* Required Fields */
        [JsonProperty(PropertyName = "source")]
        public string Source = Helpers.SourceApiVersion;

        [JsonProperty(PropertyName = "target_id")]
        public string TargetId { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /* Optional Fields */
        [JsonProperty(PropertyName = "note")]
        public string Note { get; set; }

        [JsonProperty(PropertyName = "revenue")]
        public decimal Revenue { get; set; }

        [JsonProperty(PropertyName = "account")]
        public Account Account { get; set; }

        [JsonProperty(PropertyName = "links")]
        public ActionLink[] Links { get; set; }

        [JsonProperty(PropertyName = "extras")]
        public Dictionary<string, object> Extras { get; set; }
    }
}
