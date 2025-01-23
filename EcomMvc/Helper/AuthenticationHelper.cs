using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using EcomMvc.Helper.Interface;
using EcomMvc.Models;
using Microsoft.IdentityModel.Tokens;

namespace EcomMvc.Helper
{
    public class AuthenticationHelper  : IHelper 
    {
        private readonly IConfiguration _configuration;

        public AuthenticationHelper(IConfiguration configution)
        {
            _configuration = configution;
        }
        public string IssueToken(LoginViewModel user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
      
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name , user.UserName),
            };
          //  user.Roles.ForEach(role => claims.Add(new Claim(ClaimTypes.Role, role)));



                var token = new JwtSecurityToken(
                    issuer: _configuration["Jwt:Issuer"],
                    audience: _configuration["Jwt:Audience"],
                    claims: claims,
                    expires: DateTime.Now.AddHours(1),
                    signingCredentials: credentials 
                    );



            // Serializes  JWT token -->> string & returns
            return new JwtSecurityTokenHandler().WriteToken(token);
        }
        

        
    }
}
