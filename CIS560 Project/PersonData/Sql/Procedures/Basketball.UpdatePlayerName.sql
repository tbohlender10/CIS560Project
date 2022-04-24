CREATE OR ALTER PROCEDURE Basketball.UpdatePlayerName
	@PlayerName NVARCHAR(128),
	@School NVARCHAR(64),
	@Number INT
AS

UPDATE Basketball.Player
SET [Name] = @PlayerName
WHERE Number = @Number
	AND SchoolID =
	(
		SELECT S.SchoolID
		FROM Basketball.School S
		WHERE S.[Name] = @School
	)
GO