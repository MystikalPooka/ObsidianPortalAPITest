using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObsidianAPITEST.Entities
{
    internal class UserCampaign
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("campaign_url")]
        public string CampaignUrl { get; set; }
        [JsonProperty("visibility")]
        public string Visibility { get; set; }
        [JsonProperty("role")]
        public string Role { get; set; } // Note(Dan): Probably change this to enum
    }
}
