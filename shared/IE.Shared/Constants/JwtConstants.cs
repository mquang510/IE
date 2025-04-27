using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IE.Shared.Constants
{
    public static class JwtAppConstants
    {
        public const string ClaimEmail = "http://schemas.xmlsoap.org/ws/2005/05/identity/claims/emailaddress";
        public const string PrivateKey = "b3b04a0c95be4168b3263337828a7b282eb5b1a061ab78686d31c4dd4a1d657e";
        public const string Issuer = "IE.Project";
        public const string Audience = "IE.Audience";
        public const int ExpiredHour = 6;
    }
}
