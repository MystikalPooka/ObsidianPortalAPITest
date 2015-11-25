using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObsidianAPITEST.Entities;
using System.Net.Http;
using Newtonsoft.Json;

namespace ObsidianAPITEST.Services
{
    class DynamicSheetTemplateServices
    {
        public string _DSTBaseApiUrl = " http://api.obsidianportal.com/v1/";

        public async Task<List<DynamicSheetTemplate>> GetDynamicSheetTemplates()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync($"{_DSTBaseApiUrl}dynamic_sheet_templates.json");

                if (string.IsNullOrWhiteSpace(result))
                    return null;

                return JsonConvert.DeserializeObject<List<DynamicSheetTemplate>>(result);
            }
        }

        public async Task<DynamicSheetTemplate> GetDynamicSheetTemplateByID(string id)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync($"{_DSTBaseApiUrl}dynamic_sheet_templates/{id}.json");

                if (string.IsNullOrWhiteSpace(result))
                    return null;

                return JsonConvert.DeserializeObject<DynamicSheetTemplate>(result);
            }
        }

        public async Task<DynamicSheetTemplate> GetDynamicSheetTemplateBySlug(string slug)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync($"{_DSTBaseApiUrl}dynamic_sheet_templates/{slug}.json?use_slug=true");

                if (string.IsNullOrWhiteSpace(result))
                    return null;

                return JsonConvert.DeserializeObject<DynamicSheetTemplate>(result);
            }
        }


    }
}
