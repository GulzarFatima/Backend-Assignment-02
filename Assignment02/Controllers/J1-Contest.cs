using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/J1")]
    [ApiController]
    public class CupcakeParty : ControllerBase
    {
        /// <summary>
        /// <param name="Regular"></param>
        /// <param name="Small"></param>
        /// <returns> 

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