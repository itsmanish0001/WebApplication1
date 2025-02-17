using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
       
        private const string HardcodedUsername = "admin";
        private const string HardcodedPassword = "password123";

        
        public IActionResult Index()
        {
            return View();
        }

      
        [HttpPost]
        public IActionResult Login(LoginViewModel model)
        {
            if (model.Username == HardcodedUsername && model.Password == HardcodedPassword)
            {
               
                return RedirectToAction("Index", "Calculator");
            }

            
            ViewBag.ErrorMessage = "Invalid username or password.";
            return View("Index");
        }
    }
}
