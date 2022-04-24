CREATE OR ALTER PROCEDURE Basketball.CreateNewPlayer
	@School NVARCHAR(64),
	@PlayerName NVARCHAR(128),
	@Number INT,
	@Grade NVARCHAR(64),
	@Position NVARCHAR(64)
AS

INSERT Basketball.Player(SchoolID, [Name], Number, Grade, Position)
SELECT S.SchoolID, PlayerInfo.PlayerName, PlayerInfo.Number, PlayerInfo.Grade, PlayerInfo.Position
FROM 
(
	VALUES
	(@School, @PlayerName, @Number, @Grade, @Position)
) PlayerInfo(School, PlayerName, Number, Grade, Position)
INNER JOIN Basketball.School S ON S.[Name] = PlayerInfo.School
GO