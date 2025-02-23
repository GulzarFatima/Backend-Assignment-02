using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/J3")]
    [ApiController]
    public class J3_DecodeSecret : ControllerBase
    {
        /// <summary>
        /// Decode secret formula to intrsuctions for directions. 
        /// </summary>
        /// <param name="formulas">
        /// A comma-separated list of 5 numbers,
        /// where: the first two digits determine the direction (Right/Left/Same as last direction).
        /// The last three digits determine the number of steps to take in that direction.     
        /// "99999" is the end of the input and should not be processed.
        /// </param>
        /// </returns>
        /// <example>
        /// Request: api/J3/DecodedFormula?formulas=57234,00907,34100,99999
        /// Response: ["right 234", "right 907", "left 100"]
        /// </example>
      
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
