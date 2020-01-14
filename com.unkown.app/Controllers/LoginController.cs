using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using com.unkown.app.Utility.JWT;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace com.unkown.app.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _log;
        private readonly IConfiguration _configuration;
        public LoginController(ILogger<LoginController> log, IConfiguration configuration)
        {
            _log = log;
            _configuration = configuration;
            _log.LogInformation("LoginController.......");
        }
        [HttpGet("token")]
        public async Task<ActionResult<string>> GetToken(string username, string password)
        {
            return await JwtHandler.CreateJwtToken();
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<string>> GetValue(int id)
        {
            return await Task.Run(() => "This is GetValue!!!---" + id);
        }

        [HttpGet("error")]
        public string GetException()
        {
            return _configuration["sssss"].ToString();
        }


        #region 
        // GET: api/Login
        //[HttpGet]
        //public IEnumerable<string> Get()
        //{

        //    return new string[] { "value1", "value2" };
        //}
        //// GET: api/Login/5
        //[HttpGet("{id}", Name = "Get")]
        //public string Get(int id)
        //{
        //    return "value";
        //}

        //// POST: api/Login
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT: api/Login/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE: api/ApiWithActions/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
        #endregion
    }
}
