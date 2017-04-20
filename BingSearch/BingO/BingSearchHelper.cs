using System;
using System.Net.Http.Headers;
using System.Text;
using System.Net.Http;
using System.Web;
using System.Threading.Tasks;
using System.Diagnostics;
using BingO.Exceptions;

namespace BingO
{
    public class BingQueryParameters
    {
        public int count { get; set; }
        public int offset { get; set; }
        public string mkt { get; set; }
        public string safesearch { get; set; }
        public string APIKey { get; set; }

        public BingQueryParameters(string apiKey, string mkt, int count, int offset, string safeSearch)
        {
            this.count = count;
            APIKey = apiKey;
            this.offset = offset;
            safesearch = safeSearch;
            this.mkt = mkt;
        }
    }
    public class BingSearchHelper
    {
        /// <summary>
        /// Query's the bing search api for anything
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parameters"></param>
        /// <returns>Search result containing links, images, news...</returns>
        public static async Task<SearchResult> Query(string query, BingQueryParameters parameters)
        {
            HttpClient client = new HttpClient();
            var queryString = HttpUtility.ParseQueryString(string.Empty);

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", $"{parameters.APIKey}");
            queryString["q"] = query;
            foreach(var property in parameters.GetType().GetProperties())
            {
                if(property.Name.Equals("APIKey") || property.GetValue(parameters) == null)
                {
                    continue;
                }
                else
                {
                    //Get the property's name and its value and set it to the query string
                    queryString[property.Name] = property.GetValue(parameters).ToString();
                }
            }

            var uri = "https://api.cognitive.microsoft.com/bing/v5.0/search?" + queryString;
            Debug.WriteLine(uri.ToString());
            var response = await client.GetAsync(uri);
            string respString = await response.Content.ReadAsStringAsync();
            var searchResult = Newtonsoft.Json.JsonConvert.DeserializeObject<SearchResult>(respString);

            if(searchResult._type == null)
            {
                BingSearchException exception = Newtonsoft.Json.JsonConvert.DeserializeObject<BingSearchException>(respString);
                switch(exception.StatusCode)
                {
                    case 403:
                        throw new OutOfCallVolumeQuotaException();
                        break;
                    case 401:
                        throw new AccessDeniedException();
                        break;
                    case 429:
                        throw new RateLimitExceededException();
                }
            }
            return searchResult;
        }
    }
}
