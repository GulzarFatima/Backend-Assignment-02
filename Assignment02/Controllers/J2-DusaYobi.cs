using System;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.J2
{
    [Route("api/J2")]
    [ApiController]
    public class DusaYobi : ControllerBase
    {
        /// <summary>
        /// Dusa is a monster and it eats yobis that are smaller than its size.
        /// Dusa runs away if it encounters a yobi that is bigger than its size.
        /// We want to calculate the final size of Dusa after eating all the yobis.
        /// </summary>
        /// <param name="dusa"> The initial size of Dusa (5). </param>
        /// <param name="yobis"> A comma-separated string of Yobis with mixed sizes (bigger/smaller).</param>
        /// </returns>
        /// <example>
        /// Request:
        /// GET api/J2/DusaYobis?dusa=5&yobis=3,2,9,20,22,14
        /// 
        /// Response:
        /// 19
        /// </example>

        [HttpGet("DusaYobis")]
        public IActionResult CalculateDusaSize([FromQuery] int dusa, string yobis)
        {
            var yobiSizes = yobis.Split(',');
            int dusaSize = dusa;

            foreach (string yobi in yobiSizes)
            {
                int yobiSize = int.Parse(yobi);
                if (yobiSize < dusaSize)
                {
                    dusaSize += yobiSize;
    }
                else
                {
                    break;
                }
            }
            return Ok(dusaSize);
        }
    }
}