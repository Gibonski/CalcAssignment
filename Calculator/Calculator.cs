using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class Calculator : ControllerBase
    {
        public IActionResult Add(decimal num1, decimal num2)
        {
            decimal addition = num1 + num2;
            return Ok(new { num1, num2, addition });
        }

        public IActionResult Subtract(decimal num1, decimal num2)
        {
            decimal subtraction = num1 - num2;
            return Ok(new { num1, num2, subtraction });
        }

        public IActionResult Multiply(decimal num1, decimal num2)
        {
            decimal Multiplication = num1 * num2;
            return Ok(new { num1, num2, Multiplication });
        }

        public IActionResult Divide(decimal num1, decimal num2)
        {
            
            decimal division = num1 / num2;
            return Ok(new { num1, num2, division });
        }

        public IActionResult Modulo(decimal num1, decimal num2)
        {

            decimal remainder = num1 % num2;
            return Ok(new { num1, num2, remainder });
        }
    }
}
