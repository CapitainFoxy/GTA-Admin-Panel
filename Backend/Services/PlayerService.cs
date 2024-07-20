using GTAServerAdmin.Models;
using System.Collections.Generic;
using System.Linq;

namespace GTAServerAdmin.Services
{
    public class PlayerService
    {
        private readonly List<Player> _players = new List<Player>();

        public Player GetPlayerById(int id)
        {
            return _players.FirstOrDefault(p => p.Id == id);
        }

        public Player CreatePlayer(Player player)
        {
            player.Id = _players.Count + 1;
            _players.Add(player);
            return player;
        }
    }
}
