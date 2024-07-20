using Microsoft.AspNetCore.Mvc;
using GTAServerAdmin.Models;
using GTAServerAdmin.Services;

namespace GTAServerAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BanController : ControllerBase
    {
        private readonly BanService _banService;

        public BanController(BanService banService)
        {
            _banService = banService;
        }

        [HttpPost]
        public ActionResult<Ban> BanPlayer([FromBody] Ban ban)
        {
            _banService.BanPlayer(ban);
            return CreatedAtAction(nameof(BanPlayer), new { id = ban.Id }, ban);
        }

        [HttpDelete("{id}")]
        public ActionResult UnbanPlayer(int id)
        {
            _banService.UnbanPlayer(id);
            return NoContent();
        }
    }
}
