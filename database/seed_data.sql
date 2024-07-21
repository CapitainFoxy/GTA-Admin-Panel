USE GTAServerAdmin;
GO

-- Insert sample players
INSERT INTO Players (Name, Score, LastLogin)
VALUES 
    ('Player1', 100, GETDATE()),
    ('Player2', 150, GETDATE()),
    ('Player3', 200, GETDATE());
GO

-- Insert sample bans
INSERT INTO Bans (PlayerID, Reason)
VALUES 
    (1, 'Cheating'),
    (2, 'Abusive Language');
GO
