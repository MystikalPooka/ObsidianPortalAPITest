using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObsidianAPITEST.Entities;
using Newtonsoft.Json;
using System.Net.Http;

namespace ObsidianAPITEST.Services
{
    internal class UserService
    {
        public string _userBaseApiUrl = "http://api.obsidianportal.com/v1/users/";

        public async Task<User> GetLoggedInUser()
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync($"{_userBaseApiUrl}me.json");

                if (string.IsNullOrWhiteSpace(result))
                    return null;

                return JsonConvert.DeserializeObject<User>(result);
            }
        }

        public async Task<User> GetUserById(Guid id)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync($"{_userBaseApiUrl}{id}.json");

                if (string.IsNullOrWhiteSpace(result))
                    return null;

                return JsonConvert.DeserializeObject<User>(result);
            }
        }

        public async Task<User> GetUserByUsername(string userName)
        {
            using (var httpClient = new HttpClient())
            {
                var result = await httpClient.GetStringAsync($"{_userBaseApiUrl}{userName}.json?use_username=true");

                if (string.IsNullOrWhiteSpace(result))
                    return null;

                return JsonConvert.DeserializeObject<User>(result);
            }
        }

    }
}
