using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
        [HttpPost]
        public IActionResult Calculate(string operation, double num1, double num2)
        {
            double result = 0;
            switch (operation)
            {
                case "add":
                    result = num1 + num2;
                    break;
                case "subtract":
                    result = num1 - num2;
                    break;
                case "multiply":
                    result = num1 * num2;
                    break;
                case "divide":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        ViewBag.ErrorMessage = "Cannot divide by zero.";
                        return View("Index");
                    }
                    break;
                default:
                    ViewBag.ErrorMessage = "Invalid operation.";
                    return View("Index");
            }

            ViewBag.Result = result;
            return View("Index");
        }
    }
}
