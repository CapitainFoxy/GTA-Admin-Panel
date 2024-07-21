-- Create the database
CREATE DATABASE GTAServerAdmin;
GO

USE GTAServerAdmin;
GO

-- Create table for players
CREATE TABLE Players (
    PlayerID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Score INT NOT NULL,
    LastLogin DATETIME
);
GO

-- Create table for server settings
CREATE TABLE ServerSettings (
    SettingID INT PRIMARY KEY IDENTITY(1,1),
    ServerName NVARCHAR(100) NOT NULL,
    MaxPlayers INT NOT NULL
);
GO

-- Create table for bans
CREATE TABLE Bans (
    BanID INT PRIMARY KEY IDENTITY(1,1),
    PlayerID INT FOREIGN KEY REFERENCES Players(PlayerID),
    Reason NVARCHAR(255),
    BanDate DATETIME DEFAULT GETDATE()
);
GO

-- Create table for server logs
CREATE TABLE ServerLogs (
    LogID INT PRIMARY KEY IDENTITY(1,1),
    LogDate DATETIME DEFAULT GETDATE(),
    LogLevel NVARCHAR(50),
    Message NVARCHAR(MAX)
);
GO

-- Insert default server settings
INSERT INTO ServerSettings (ServerName, MaxPlayers)
VALUES ('Default GTA Server', 32);
GO
