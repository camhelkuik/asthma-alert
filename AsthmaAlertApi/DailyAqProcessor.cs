
using System;
using System.Net.Http;
using System.Threading.Tasks;
using AsthmaAlertApi.Models;

namespace AsthmaAlertApi
{
    public class DailyAqProcessor
    {
        public static async Task<DailyAq> GetDailyAq()
        {
            string url = "http://dataservice.accuweather.com/forecasts/v1/daily/1day/349291?apikey=y3bDUp7pmwjK9HjzWV6gkrNRorKYpkLI&details=true";

            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync(url))
            {
                if (response.IsSuccessStatusCode)
                {
                    DailyAqResult result = await response.Content.ReadAsAsync<DailyAqResult>();
                    //may need to map json to model
                    return result.Results;
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }

        }
    }
}