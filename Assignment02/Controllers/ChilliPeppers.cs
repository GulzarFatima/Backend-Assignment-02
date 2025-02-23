using System;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.J2
{
    [Route("api/J2")]
    [ApiController]
    public class ChiliPeppers : ControllerBase
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
        /// <param name="ingredients">A comma-separated list of chili pepper names.</param>
        /// <returns>
        /// Returns total spiciness (sum of Scoville Heat Units) of the selected peppers.
        /// </returns>
        /// <example>
        /// Request:
        /// GET /api/J2/ChiliPeppers?Ingredients=Poblano,Cayenne,Thai,Poblano
        /// 
        /// Response:
        /// 118000
        /// </example>

        [HttpGet("ChiliPeppers")]
        public IActionResult CalculateSpiciness([FromQuery] string ingredients)
        {
            var chosenPeppers = ingredients.Split(',');
            int totalSpiciness = 0;

            foreach (string pepper in chosenPeppers)
            {
                totalSpiciness += peppers[pepper.Trim()];
            }
            return Ok(totalSpiciness);
        }
    }
}
