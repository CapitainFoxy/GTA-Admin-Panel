document.addEventListener('DOMContentLoaded', () => {
    // Load player list
    fetch('https://localhost:5001/api/player')
        .then(response => response.json())
        .then(players => {
            const playerList = document.getElementById('player-list');
            players.forEach(player => {
                const listItem = document.createElement('li');
                listItem.textContent = `${player.name} - Score: ${player.score}`;
                playerList.appendChild(listItem);
            });
        });

    // Update server settings
    const settingsForm = document.getElementById('settings-form');
    settingsForm.addEventListener('submit', (event) => {
        event.preventDefault();
        const serverName = document.getElementById('server-name').value;
        const maxPlayers = document.getElementById('max-players').value;

        fetch('https://localhost:5001/api/serversettings', {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({
                serverName: serverName,
                maxPlayers: parseInt(maxPlayers, 10)
            })
        }).then(response => {
            if (response.ok) {
                alert('Settings updated successfully.');
            } else {
                alert('Failed to update settings.');
            }
        });
    });
});
