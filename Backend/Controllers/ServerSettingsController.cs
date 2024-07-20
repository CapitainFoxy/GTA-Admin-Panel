using Microsoft.AspNetCore.Mvc;
using GTAServerAdmin.Models;
using GTAServerAdmin.Services;

namespace GTAServerAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ServerSettingsController : ControllerBase
    {
        private readonly ServerSettingsService _settingsService;

        public ServerSettingsController(ServerSettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet]
        public ActionResult<ServerSettings> GetSettings()
        {
            var settings = _settingsService.GetSettings();
            return Ok(settings);
        }

        [HttpPut]
        public ActionResult UpdateSettings([FromBody] ServerSettings settings)
        {
            _settingsService.UpdateSettings(settings);
            return NoContent();
        }
    }
}
