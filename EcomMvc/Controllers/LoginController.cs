using EcomMvc.Helper;
using EcomMvc.Helper.Interface;
using EcomMvc.Models;
using EcomMvc.Repository.Interface;
using Microsoft.AspNetCore.Mvc;


namespace EcomMvc.Controllers
{
    public class LoginController : Controller
    {

        private readonly IUserRepository _userRepository;
        private readonly IHelper _helper;

        public LoginController(IUserRepository userRepository, IHelper helper)
        {
            _userRepository = userRepository;
            _helper = helper;
        }



        [HttpGet]
        public IActionResult Login()
        {

            return View();
        }


        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var existingUser = await _userRepository.GetValidUser(model.UserName, model.Password);

                if (existingUser != null)
                {
                    var token = _helper.IssueToken(model);

                    return RedirectToAction("Index", "Home");
                }
            }
            return View(model);
        }

    }





      
    
}
