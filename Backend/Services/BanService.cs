using GTAServerAdmin.Models;
using System.Collections.Generic;
using System.Linq;

namespace GTAServerAdmin.Services
{
    public class BanService
    {
        private readonly List<Ban> _bans = new List<Ban>();

        public void BanPlayer(Ban ban)
        {
            _bans.Add(ban);
        }

        public void UnbanPlayer(int id)
        {
            var ban = _bans.FirstOrDefault(b => b.Id == id);
            if (ban != null)
            {
                _bans.Remove(ban);
            }
        }
    }
}
