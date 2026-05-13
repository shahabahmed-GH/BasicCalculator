using Microsoft.AspNetCore.Mvc;
using CalculatorBasic.Models;

namespace CalculatorBasic.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View( new CalculatorModel());
        }
        [HttpPost]
        public IActionResult Calculate(CalculatorModel model)
        {
            double a = model.Num1 ?? 0;
            double b = model.Num2 ?? 0;
            if(model.Operation == "Add")
            {
                model.Result = a + b;
            }
            else if (model.Operation == "Subtract")
            {
                model.Result = a - b;
            }
            else if (model.Operation == "Multiply")
            {
                model.Result = a * b;
            }
            else if (model.Operation == "Divide")
            {
                if(b == 0)
                {
                    model.ErrorMessage = "Cant Divide With 0";
                }
                else
                {
                    model.Result = a / b;

                }
            }
            return View("Index", model);
        }
    }
}
