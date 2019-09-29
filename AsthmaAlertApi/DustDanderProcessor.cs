
using System;
using System.Net.Http;
using System.Threading.Tasks;
using AsthmaAlertApi.Models;

namespace AsthmaAlertApi
{
    public class DustDanderProcessor
    {    
        public static async Task<DustDander> GetDustDander()
        {
            string url = "http://dataservice.accuweather.com/indices/v1/daily/1day/349291/groups/1?apikey=y3bDUp7pmwjK9HjzWV6gkrNRorKYpkLI";

             using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    DustDander result = await response.Content.ReadAsAsync<DustDander>();
                    //may need to map json to model
                    return result;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}