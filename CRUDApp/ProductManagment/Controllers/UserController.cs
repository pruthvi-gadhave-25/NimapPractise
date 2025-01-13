using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using ProductManagment.Data;
using ProductManagment.Models;
using ProductManagment.Services.Interface;

namespace ProductManagment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly AppDbContext _dbContext;
        private readonly IConfiguration _configuration;

        public UserController( IUserService userService  , AppDbContext dbContext  , IConfiguration configuration)
        {
            _userService = userService;
            _dbContext = dbContext;
            _configuration = configuration;
        }

        //Registration 
        [HttpPost("register")]
        public async Task<IActionResult>AddUser(User user)
        {
            try
            {
                await _userService.AddUser(user);
                return Ok(user);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize ]
        [HttpGet("id")]
        public async Task<IActionResult> GetUserByID(int id)
        {
            try
            {
                var user = await _userService.GetUser(id);

                if (user == null)
                {
                    return NotFound();
                }

                return Ok(user);
            }catch(Exception ex)
            {
                return NotFound(ex.Message);
            }
        }



        [HttpGet("getusers")]
        public async Task<IActionResult> GetAllUsers()
        {
            var users =   await _userService.GetAllUsers();
            return Ok(users);
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(string username, string password)
        {
            var userLogin = await _dbContext.Users.FirstOrDefaultAsync(x => (x.UserName == username && x.Password == password));

            if (userLogin != null)
            {
                var claims = new[]
                {
                    new Claim(JwtRegisteredClaimNames.Sub , _configuration["Jwt:Subject"]),
                    new Claim(JwtRegisteredClaimNames.Jti , Guid.NewGuid().ToString() ) ,
                    new Claim("userId", userLogin.Id.ToString()),
                    new Claim("userName", userLogin.UserName.ToString())                                
                };

                var key =  new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key , SecurityAlgorithms.HmacSha256);

                var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"] ,
                _configuration["Jwt:Audience"] ,
                claims ,

                expires: DateTime.Now.AddHours(1),
                signingCredentials : signIn 
            );

                string tokenValue = new JwtSecurityTokenHandler().WriteToken(token);


                return Ok(tokenValue);

            }
            return BadRequest();

        }

    }
}
