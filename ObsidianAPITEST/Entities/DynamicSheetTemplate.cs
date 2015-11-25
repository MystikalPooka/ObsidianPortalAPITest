using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObsidianAPITEST.Entities
{
    internal class DynamicSheetTemplate
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("slug")]
        public string Slug { get; set; }
        [JsonProperty("user")]
        public MiniUser User { get; set; }
        [JsonProperty("game_system")]
        public MiniGameObject GameSystem { get; set; }
        [JsonProperty("html_template")]
        public string HtmlTemplate { get; set; }
        [JsonProperty("css")]
        public string Css { get; set; }
        [JsonProperty("javascript")]
        public string Javascript { get; set; }
        [JsonProperty("state")]
        public string State { get; set; } //Can be one of "new", "submitted", "approved", "resubmitted", "modification_required"
        [JsonProperty("created_at")]
        public DateTime CreatedAt { get; set; }
        [JsonProperty("updated_at")]
        public DateTime UpdatedAt { get; set; }

        //Author Only (available only to the DST author)
        [JsonProperty("html_template_submitted")]
        public string HtmlTemplateSubmitted { get; set; }
        [JsonProperty("css_submitted")]
        public string CssSubmitted { get; set; }
        [JsonProperty("javascript_submitted")]
        public string JavascriptSubmitted { get; set; }


    }
}
