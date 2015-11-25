using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObsidianAPITEST.Entities
{
    internal class Character
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("avatar_url")]
        public string AvatarUrl { get; set; }
        [JsonProperty("campaign")]
        public MiniCampaign Campaign { get; set; }
        [JsonProperty("visibility")]
        internal string RawVisibility { get; set; }

        [JsonIgnore]
        public ObsidianVisibility Visibility
        {
            get
            {
                switch(RawVisibility)
                {
                    case "public":
                        return ObsidianVisibility.Public;
                    case "friends":
                        return ObsidianVisibility.Friends;
                    case "private":
                        return ObsidianVisibility.Private;
                }
                throw new Exception();
            }
            set
            {
                switch (value)
                {
                    case ObsidianVisibility.Public:
                        RawVisibility = "public";
                        break;
                    case ObsidianVisibility.Friends:
                        RawVisibility = "friends";
                        break;
                    case ObsidianVisibility.Private:
                        RawVisibility = "private";
                        break;
                }
            }
        }

        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        //Public / Private / Friends Visibility (availability depends on campaign's visibility)
        [JsonProperty("author")]
        public MiniUser Author { get; set; }
        [JsonProperty("is_player_character")]
        public bool IsPlayerCharacter { get; set; }
        [JsonProperty("is_game_master_only")]
        public bool IsGameMasterOnly { get; set; }
        [JsonProperty("dynamic_sheet_template")]
        public DynamicSheetTemplate DynamicSheetTemplate { get; set; }

        //JSONObject dynamic_sheet

        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("description_html")]
        public string DescriptionHtml { get; set; }
        [JsonProperty("bio")]
        public string Bio { get; set; }
        [JsonProperty("bio_html")]
        public string BioHtml { get; set; }
        [JsonProperty("tags")]
        public List<string> Tags { get; set; }
        [JsonProperty("game_master_info")]
        public string GameMasterInfo { get; set; }
        [JsonProperty("game_master_info_markup")]
        public string GameMasterInfoMarkup { get; set; }
    }
}
