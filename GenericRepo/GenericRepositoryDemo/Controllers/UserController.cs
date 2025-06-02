using GenericRepositoryDemo.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using GenericRepositoryDemo.Models;

namespace GenericRepositoryDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public async Task AddUser(User user)
        {
            await _userService.AddUser(user);
        }
    }
}
