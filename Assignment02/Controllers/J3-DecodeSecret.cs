using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/J3")]
    [ApiController]
    public class J3_DecodeSecret : ControllerBase
    {
        [HttpGet("DecodedFormula")]
        public IActionResult DecodeFormulas([FromQuery] string formulas)
        {
            var inputlist = formulas.Split(',');
            var results = new List<string>();
            string lastDirection = "";

            foreach (string formula in inputlist)
            {
                if (formula == "99999")
                {
                    break;
                }

                int firstNumber = int.Parse(formula.Substring(0, 1));
                int secondNumber = int.Parse(formula.Substring(1, 1));
                int lastThreeNumbers = int.Parse(formula.Substring(2, 3));

                int sum = firstNumber + secondNumber;


                string direction;

                if (sum == 0)
                {
                    direction = lastDirection;
                }
                else if (sum % 2 == 0) // even number
                {
                    direction = "right";
                }
                else // odd number
                {
                    direction = "left";
                }


                lastDirection = direction;
                results.Add(direction + " " + lastThreeNumbers);

            }
            return Ok(results);
        }
    }
}
