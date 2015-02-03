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
using System;
using System.Collections.Generic;

using Newtonsoft.Json;

namespace Preact
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Person
    {
        /* Required Fields */
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }

        /* Strongly Suggested Fields */
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty(PropertyName = "uid")]
        public string Uid { get; set; }

        /* Optional Fields */
        [JsonProperty(PropertyName = "twitter_id")]
        public string TwitterId { get; set; }

        [JsonProperty(PropertyName = "facebook_id")]
        public string FacebookId { get; set; }

        [JsonProperty(PropertyName = "stripe_id")]
        public string StripeId { get; set; }

        [JsonProperty(PropertyName = "properties")]
        public Dictionary<string, object> Properties { get; set; }
    }
}
