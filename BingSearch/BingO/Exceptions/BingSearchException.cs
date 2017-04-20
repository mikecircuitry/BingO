using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BingO.Exceptions
{
    [Serializable]
    public class BingSearchException : Exception
    {
        [JsonProperty(PropertyName = "statusCode")]
        public int StatusCode { get; set; }

        public BingSearchException(string message, int statusCode) : base(message)
        {
            StatusCode = statusCode;
        }
    }
}
