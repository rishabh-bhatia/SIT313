using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ConferenceSessionsClient.Model;

namespace ConferenceSessionsClient.Data
{
    public class SessionsManager
    {
        HttpClient client = new HttpClient();
        List<Session> ConferenceSessions = null;

        public async Task<List<Session>> FetchSessionsAsync()
        {
            string url = "http://192.168.0.8:5001/api/conferencesessions/";
            try
            {
                var response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    ConferenceSessions = JsonConvert.DeserializeObject<List<Session>>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"       Error{0} ", ex.Message);
            }
            return ConferenceSessions;
        }
    }
}
