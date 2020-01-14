using System;
using System.Collections.Generic;
using System.Text;

namespace com.unkown.app.Utility.Result
{
    public class GlobalJsonResult
    {
        public int code { get; set; }
        public string msg { get; set; }
        public ResponseData data { get; set; }
        public class ResponseData
        {

        }
    }
    
}
