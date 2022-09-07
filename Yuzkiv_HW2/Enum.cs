using System;

namespace HW_2
{
    public class Enum
    {
        public enum HTTPError
        {
            BadRequest = 400,
            Unauthorized = 401,
            PaymentRequired = 402,
            Forbidden = 403,
            NotFound = 404
        }
    }
}
