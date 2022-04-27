-- This procedure retrieves the schools for a specific game.
CREATE OR ALTER PROCEDURE Basketball.RetrieveSchoolsForGame
	@GameID INT
AS

SELECT S.SchoolID, S.[Name], S.Coach, S.Seed, S.RegionID
FROM Basketball.Game G
	INNER JOIN Basketball.GameSchool GS ON G.GameID = GS.GameID
	INNER JOIN Basketball.School S ON S.SchoolID = GS.SchoolID
WHERE G.GameID = @GameID AND G.IsDeleted = 0 AND GS.IsDeleted = 0 AND S.IsDeleted = 0;
GO
