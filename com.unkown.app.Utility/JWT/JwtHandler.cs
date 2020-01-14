using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;

namespace com.unkown.app.Utility.JWT
{
    public class JwtHandler
    {
        private static JwtConfiguration configuration;
        public static JwtConfiguration Configuration { set { configuration = value; } }

        public static async Task<string> CreateJwtToken()
        {
            return await Task.Run(() =>
            {
                //规则
                var claims = new Claim[] {
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                    new Claim("userid", "1"),
                    new Claim("username","admin"),
                };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration.SecurityKey));
                var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                    issuer: configuration.Issuer,
                    audience: configuration.Audience, 
                    claims: claims,
                    notBefore: DateTime.Now,
                    expires: DateTime.Now.AddSeconds(configuration.ExpireSeconds),
                    signingCredentials: creds);

                return new JwtSecurityTokenHandler().WriteToken(token);
            });
        }

    }
}
