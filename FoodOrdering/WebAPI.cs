using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Web.Http;

namespace FoodOrdering
{
    public static class WebAPI
    {
        const string endpoint = "http://lynerassignment.azurewebsites.net/api/";

        public static async Task<List<string>> GetRestaurantsAsync()
            => await getJsonAsync<List<string>>("Restaurants");

        private static async Task<T> getJsonAsync<T>(string api)
        {
            try
            {
                var hc = new HttpClient();
                var result = await hc.GetStringAsync(new Uri(endpoint + api));
                var obj = JsonConvert.DeserializeObject<T>(result);
                return obj;
            }
            catch
            {
                return default(T);
            }
        }
    }
}
