using System;
using Newtonsoft.Json;

namespace Preact
{
    [JsonObject(MemberSerialization.OptIn)]
    public class Account
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "license_type")]
        public string LicenseType { get; set; }

        [JsonProperty(PropertyName = "license_count")]
        public int LicenseCount { get; set; }

        [JsonProperty(PropertyName = "license_renewal")]
        public string LicenseRenewal { get; set; }
    }
}
