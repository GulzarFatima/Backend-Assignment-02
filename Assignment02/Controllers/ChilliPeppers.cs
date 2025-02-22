using System;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.J2
{
    [Route("api/J2")]
    [ApiController]
    public class ChilliPeppers : ControllerBase
    {
        Dictionary<string, int> peppers = new Dictionary<string, int>()
                        {
                            { "Poblano" , 1500 },
                            { "Mirasol" , 6000 },
                            { "Serrano" , 15500 },
                            { "Cayenne" , 40000 },
                            { "Thai" , 75000 },
                            { "Habenero" , 125000 },

                        };
        /// <summary>
        /// Calculates the total spiciness level based on the selected chili peppers.
        /// </summary>
        /// <param name="input">A comma-separated list of chili pepper names.</param>
        /// <returns>
        /// Returns an HTTP 200 OK response with the total spiciness (sum of Scoville Heat Units) of the selected peppers.
        /// If an invalid pepper name is included, it will cause an error.
        /// </returns>
        /// <example>
        /// Request:
        /// GET /api/J2/CalculateSpiciness?input=Poblano,Serrano,Thai
        /// 
        /// Response:
        /// 91500
        /// </example>
        
        [HttpGet("CalculateSpiciness")]
        public IActionResult CalculateSpiciness([FromQuery] string input)
        {
            var chosenPeppers = input.Split(',');
            int totalSpiciness = 0;

            foreach (string pepper in chosenPeppers)
            {
                totalSpiciness += peppers[pepper.Trim()];
            }
            return Ok(totalSpiciness);
        }
    }
}
