using Microsoft.AspNetCore.Mvc;
using Entities;
using Services.Zone;

namespace Controllers
{
    [ApiController]
    [Route("api/me")]
    public class UserController : ControllerBase
    {

        [HttpGet("safe/zone")]
        public IActionResult GetSafeLocation()
        {

            List<Zone> zone = SafeZoneService.getZone();

            if(zone == null)
            {
                return NotFound("Location Safe not found");
            }

            return Ok(zone);
        }


        [HttpGet("danger/zone")]
        public IActionResult GetDangerLocation()
        {

            List<Zone> zone = DangerZoneService.getZone();

            if (zone == null)
            {
                return NotFound("Location Danger not found");
            }

            return Ok(zone);
        }

        [HttpPost]
        public IActionResult UpdateUserLocation()
        {
            return Ok("User location updated successfully");
        }

    }
}
