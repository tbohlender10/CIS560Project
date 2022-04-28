-- This procedure retrieves information about the home school for a game.
CREATE OR ALTER PROCEDURE Basketball.RetrieveHomeSchoolForGame
	@GameID int
AS

SELECT G.GameID, S.SchoolID, S.[Name], GS.Score, GS.TeamTypeID
FROM Basketball.Game G
INNER JOIN Basketball.GameSchool GS ON G.GameID = GS.GameID
INNER JOIN Basketball.School S ON S.SchoolID = GS.SchoolID
WHERE G.GameID = @GameID AND GS.TeamTypeID = 1 AND G.IsDeleted = 0 AND GS.IsDeleted = 0 AND S.IsDeleted = 0;
GO