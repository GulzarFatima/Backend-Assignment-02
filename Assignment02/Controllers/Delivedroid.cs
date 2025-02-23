using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/J1")]
    [ApiController]
    public class Delivedroid : ControllerBase
    {
        /// <summary>
        /// Calculates final score of Delivedroid based on the number of collisions and deliveries.
        /// </summary>
        ///
        /// <param name="collisions">Number of collisions (each deducts 10 points).</param>
        /// <param name="delivery">Number of packages delivered (each adds 50 points).</param>
        /// <returns> 
        /// totalpoints + bonus points(500) if deliveries are more than collisions.
        /// <example>
        /// Request:
        /// POST api/J1/Delivedroid
        /// Content-Type: application/x-www-form-urlencoded
        /// Body: collisions=2&deliveries=5
        /// 
        /// Response:
        /// 730
        /// </example>

        [HttpPost("Delivedroid")]
        public IActionResult CalculateScore([FromForm] int collisions, [FromForm] int deliveries)
        {
            var deliveryPoints = deliveries * 50;
            var collisionPoints = collisions * 10;
            var totalPoints = deliveryPoints - collisionPoints;

            if (deliveries > collisions)
            {
                totalPoints = totalPoints + 500;
            }
            return Ok(totalPoints);
        }
    }
}
