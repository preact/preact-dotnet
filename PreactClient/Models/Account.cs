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
        public int? LicenseCount { get; set; }

        [JsonProperty(PropertyName = "license_renewal")]
        public DateTime? LicenseRenewal { get; set; }

        [JsonProperty(PropertyName = "license_value")]
        public int? LicenseValue { get; set; }

        [JsonProperty(PropertyName = "license_mrr")]
        public decimal? LicenseMRR { get; set; }

        [JsonProperty(PropertyName = "license_duration")]
        public int? LicenseDuration { get; set; }

        [JsonProperty(PropertyName = "license_status")]
        public string LicenseStatus { get; set; }

        [JsonProperty(PropertyName = "customer_since")]
        public DateTime? CustomerSince { get; set; }

        [JsonProperty(PropertyName = "trial_start")]
        public DateTime? TrialStart { get; set; }

        [JsonProperty(PropertyName = "trial_end")]
        public DateTime? TrialEnd { get; set; }

        [JsonProperty(PropertyName = "account_manager_name")]
        public string AccountManagerName { get; set; }

        [JsonProperty(PropertyName = "account_manager_email")]
        public string AccountManagerEmail { get; set; }
    }
}
