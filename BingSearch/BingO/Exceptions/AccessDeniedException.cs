using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingO.Exceptions
{

    public class AccessDeniedException : BingSearchException
    {
        public AccessDeniedException(string message) : base(message, 401)
        {}
        public AccessDeniedException():base("Access denied due to invalid subscription key. Make sure you are subscribed to an API you are trying to call and provide the right key.", 401)
        {}
    }
}
