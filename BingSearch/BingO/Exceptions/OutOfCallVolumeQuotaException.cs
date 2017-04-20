using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingO.Exceptions
{
    public class OutOfCallVolumeQuotaException : BingSearchException
    {
        public OutOfCallVolumeQuotaException(string message) : base(message, 403)
        {

        }
        public OutOfCallVolumeQuotaException() : base("Out of call volume quota. Quota will be replenished in 2.12 days.", 403)
        {

        }
    }
}
