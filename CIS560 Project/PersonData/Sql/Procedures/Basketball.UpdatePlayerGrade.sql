-- This procedure updates the grade of a player in the Player table.
CREATE OR ALTER PROCEDURE Basketball.UpdatePlayerGrade
	@PlayerName NVARCHAR(128),
	@School NVARCHAR(64),
	@Grade NVARCHAR(64)
AS

UPDATE Basketball.Player
SET Grade = @Grade
WHERE [Name] = @PlayerName
	AND SchoolID =
	(
		SELECT S.SchoolID
		FROM Basketball.School S
		WHERE S.[Name] = @School
	)
	AND IsDeleted = 0;
GO