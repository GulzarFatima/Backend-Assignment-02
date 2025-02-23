using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/J1")]
    [ApiController]
    public class CupcakeParty : ControllerBase
    {
        /// <summary>
        /// Calculates the number of leftover cupcakes after distributing one to each of 28 students.
        /// </summary>
        /// <param name="Regular"></param> Regular box contains 8 cupcakes.
        /// <param name="Small"></param> Small box contains 3 cupcakes.
        /// <returns> Number of cupcakes left after each student gets one.
        /// <example>
        /// Request:
        /// POST api/J1/CupcakeParty
        /// (form-data) Regular=2, Small=5
        /// 
        /// Response:
        /// 3
        /// </example> 

        [HttpPost("CupcakeParty")]
        public IActionResult CalculateScore([FromForm] int regular, [FromForm] int small)
        {
            var regularBox = regular * 8;
            var smallBox = small * 3;
            var leftOvers = regularBox + smallBox - 28;

            return Ok(leftOvers);
        }
    }
}

//// 28 students
// Regular box - 8 cup cakes
// Small box - 3 cup cakes

//Input
// 2 Regular box - 16
// 5 Small boxes - 15

// 16+15 = 31
// 31 - 28 = 3


// var leftOver = (r * 8) + (s * 3) - 28