using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingO.Exceptions
{
    public class RateLimitExceededException : BingSearchException
    {
        public RateLimitExceededException() : base("Rate limit is exceeded. Try again in 26 seconds.", 429)
        {}
        public RateLimitExceededException(string message) : base(message, 429)
        { }
    }
}
