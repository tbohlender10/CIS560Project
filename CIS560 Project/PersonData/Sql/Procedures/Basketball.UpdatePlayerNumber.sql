CREATE OR ALTER PROCEDURE Basketball.UpdatePlayerNumber
	@PlayerName NVARCHAR(128),
	@School NVARCHAR(64),
	@Number INT
AS

UPDATE Basketball.Player
SET Number = @Number 
WHERE [Name] = @PlayerName
	AND SchoolID =
	(
		SELECT S.SchoolID
		FROM Basketball.School S
		WHERE S.[Name] = @School
	)
GO