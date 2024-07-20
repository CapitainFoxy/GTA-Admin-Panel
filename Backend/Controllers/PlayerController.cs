using Microsoft.AspNetCore.Mvc;
using GTAServerAdmin.Models;
using GTAServerAdmin.Services;

namespace GTAServerAdmin.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PlayerController : ControllerBase
    {
        private readonly PlayerService _playerService;

        public PlayerController(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("{id}")]
        public ActionResult<Player> GetPlayer(int id)
        {
            var player = _playerService.GetPlayerById(id);
            if (player == null) return NotFound();
            return Ok(player);
        }

        [HttpPost]
        public ActionResult<Player> CreatePlayer([FromBody] Player player)
        {
            var createdPlayer = _playerService.CreatePlayer(player);
            return CreatedAtAction(nameof(GetPlayer), new { id = createdPlayer.Id }, createdPlayer);
        }
    }
}
