
using System.Net.Http;
using System.Net.Http.Headers;

namespace AsthmaAlertApi
{
    public static class ApiHelper
    {
        //made static because we want to open it once per application instead of everyone having their own. Simillar to using one browser with tabs
        public static HttpClient ApiClient { get; set; }

        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }
    }
}