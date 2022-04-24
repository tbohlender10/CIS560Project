CREATE OR ALTER PROCEDURE Basketball.UpdatePlayerPosition
	@PlayerName NVARCHAR(128),
	@School NVARCHAR(64),
	@Position NVARCHAR(64)
AS

UPDATE Basketball.Player
SET Position = @Position
WHERE [Name] = @PlayerName
	AND SchoolID =
	(
		SELECT S.SchoolID
		FROM Basketball.School S
		WHERE S.[Name] = @School
	)
GO