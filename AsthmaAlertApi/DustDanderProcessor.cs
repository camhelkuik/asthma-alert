
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using AsthmaAlertApi.Data;
using AsthmaAlertApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

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
                    var result = await response.Content.ReadAsAsync<DustDander>();
                    //may need to map json to model

                    // var create = DustDanders.Add(new DustDander {
                    //     Date = System.DateTime.Today.ToString("d"),
                    //     AsthmaValue = data2[23].Value,
                    //     AsthmaCategory = result[23].Category,
                    //     DustDanderValue = result[19].Value,
                    //     DustDanderCategory = result[19].Category
                    // });

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