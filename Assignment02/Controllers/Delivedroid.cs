using Microsoft.AspNetCore.Mvc;

namespace Assignment02.Controllers
{
    [Route("api/J1")]
    [ApiController]
    public class Delivedroid : ControllerBase
    {
        /// <summary>
        /// <param name="collision"></param>
        /// <param name="delivery"></param>
        /// <returns> totalpoints + bonus points(500) if deliveries more than collisions.
        /// <example> Collisions=2 & Deliveries=5 Return= 730 = </example>

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
