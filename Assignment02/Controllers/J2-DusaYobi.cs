using System;
using Microsoft.AspNetCore.Mvc;

namespace Assignment02.J2
{
    [Route("api/J2")]
    [ApiController]
    public class DusaYobi : ControllerBase
    {



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

////Dusa - 5
//Yobi
//[3
// 2
// 9
// 20
// 22
// 14]
//
//
//Dusa
//[ 8
// 10
// 19
//]

// input
//[POST] d = 5, yobis 3,2,9,20,22,14

//var dusaSize = d
//var yobisArray = yobis.split(separator: ",");

//foreach int yobiSize in yobisArray {

// if (yobiSize < dusaSize)
// {
//    dusaSize += yobiSize
//  }
// else
//{
//break
//}
//}
//Ok(dusaSize)