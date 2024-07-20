using GTAServerAdmin.Models;

namespace GTAServerAdmin.Services
{
    public class ServerSettingsService
    {
        private ServerSettings _settings = new ServerSettings
        {
            ServerName = "GTA Server",
            MaxPlayers = 32
        };

        public ServerSettings GetSettings()
        {
            return _settings;
        }

        public void UpdateSettings(ServerSettings settings)
        {
            _settings = settings;
        }
    }
}
