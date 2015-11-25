using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObsidianAPITEST.Entities
{
    internal class User
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("username")]
        public string Username { get; set; }
        [JsonProperty("avatar_image_url")]
        public string AvatarImageUrl { get; set; }
        [JsonProperty("profile_url")]
        public string ProfileUrl { get; set; }
        [JsonProperty("campaigns")]
        public List<UserCampaign> Campaigns { get; set; }
        [JsonProperty("is_ascendant")]
        public bool IsAscendant { get; set; }
        [JsonProperty("last_seen_at")]
        public DateTime LastSeenAt { get; set; }
        [JsonProperty("utc_offset")]
        public string UtcOffset { get; set; }
        [JsonProperty("locale")]
        public string Locale { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }
    }
}
