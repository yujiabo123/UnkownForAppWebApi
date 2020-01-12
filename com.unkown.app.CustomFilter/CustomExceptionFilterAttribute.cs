using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace com.unkown.app.CustomFilter
{
    public class CustomExceptionFilterAttribute : ExceptionFilterAttribute
    {
        private readonly ILogger<CustomExceptionFilterAttribute> _log;
        public CustomExceptionFilterAttribute(ILogger<CustomExceptionFilterAttribute> log)
        {
            _log = log;
        }
        public override void OnException(ExceptionContext context)
        {
            Console.WriteLine("这里是全局异常处理！！！！！");
            if (!context.ExceptionHandled)
            {
                _log.LogError(context.Exception.Message);
                _log.LogError(context.Exception.StackTrace);

                context.Result = new ObjectResult(new { code = 404, sub_msg = "未找到资源", msg = "" });
            }
        }
    }
}
