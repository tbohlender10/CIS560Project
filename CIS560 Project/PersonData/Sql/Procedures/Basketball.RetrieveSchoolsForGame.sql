CREATE OR ALTER PROCEDURE Basketball.RetrieveSchoolsForGame
	@GameID INT
AS

SELECT S.SchoolID, S.[Name], S.Coach, S.Seed, S.RegionID
FROM Basketball.Game G
INNER JOIN Basketball.GameSchool GS ON G.GameID = GS.GameID
INNER JOIN Basketball.School S ON S.SchoolID = GS.SchoolID
WHERE G.GameID = @GameID
GO
