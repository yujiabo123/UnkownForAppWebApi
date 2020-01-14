using System;
using System.Collections.Generic;
using System.Text;

namespace com.unkown.app.Utility.JWT
{
    public class JwtConfiguration
    {
        public string SecurityKey { get; set; }
        public string Issuer { get; set; }
        public string Audience { get; set; }
        public int ExpireSeconds { get; set; }
    }
}
