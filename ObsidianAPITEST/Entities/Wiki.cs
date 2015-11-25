using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObsidianAPITEST.Entities
{
    internal class Wiki
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("wiki_page_url")]
        public string WikiPageUrl { get; set; }
        [JsonProperty("campaign")]
        public MiniCampaign Campaign { get; set; }
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        //Public / Private / Friends Visibility 
        //(availability depends on campaign visibility and page's GM-only status)

        [JsonProperty("type")]
        public string Type { get; set; }
        [JsonProperty("is_game_master_only")]
        public bool IsGameMasterOnly { get; set; }
        [JsonProperty("body")]
        public string Body { get; set; }
        [JsonProperty("body_html")]
        public string BodyHtml { get; set; }
        [JsonProperty("tags")]
        public string[] Tags { get; set; }
        [JsonProperty("post_tagline")]
        public string PostTagline { get; set; }
        [JsonProperty("post_time")]
        public DateTime PostTime { get; set; }

        //GM ONLY (available only to the GM and any co-GMs)
        [JsonProperty("game_master_info")]
        public string GameMasterInfo { get; set; }
        [JsonProperty("game_master_info_markup")]
        public string GameMasterInfoMarkup { get; set; }



    }
}
