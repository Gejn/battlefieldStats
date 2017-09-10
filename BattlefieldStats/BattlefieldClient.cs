using BattlefieldStats.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BattlefieldStats
{
    /// <summary>
    /// This is the main class to manipulate
    /// </summary>
    public class BattlefieldClient : IDisposable
    {
        /// <summary>
        /// API uri
        /// </summary>
        private Uri m_apiUri = new Uri("https://battlefieldtracker.com/bf1/api/");

        private HttpClient m_httpClient;

        public BattlefieldClient(string _apiKey)
        {
            this.m_httpClient = new HttpClient { BaseAddress = m_apiUri };
            this.m_httpClient.DefaultRequestHeaders.TryAddWithoutValidation("trn-api-key", _apiKey);
        }

        /// <summary>
        /// If you want to get player information 
        /// </summary>
        /// <param name="_playerName"></param>
        /// <returns></returns>
        public async Task<RootObject> GetPlayerInfo(string _playerName)
        {
            RootObject l_result = null;

            using (var response = await this.m_httpClient.GetAsync($"Stats/DetailedStats?platform=2&displayName={_playerName}&game=tunguska"))
            {
                string responseData = await response.Content.ReadAsStringAsync();

                l_result = JsonConvert.DeserializeObject<RootObject>(responseData);
            }

            return l_result;
        }

        public void Dispose()
        {
            this.m_httpClient?.Dispose();
        }
    }
}
