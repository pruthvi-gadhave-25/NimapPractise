using EcomMvc.Data;
using EcomMvc.Models;
using EcomMvc.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace EcomMvc.Controllers
{     
    public class UserController : Controller
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }


        [HttpGet]
        public  IActionResult Add()
        {
            return View();
        }


        [HttpPost]
        public  async Task<IActionResult> Add(User user)
        {   
            if(ModelState.IsValid)
            {
                await _userRepository.AddUser(user);
                
                Console.WriteLine(user);
                return RedirectToAction("ListProducts" ,"Product");
            }
            else
            {
                return View(user);
            }

            return Ok();
        }
    }
}
