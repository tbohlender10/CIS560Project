-- This procedure fetches information about a player's stats for a specific game, including their IDs,
-- total points, 3-pionter percentage, FGM, FGA, rebounds, and minutes.
CREATE OR ALTER PROCEDURE Basketball.FetchPlayerGameStatisticsForPlayerGame
	@PlayerID INT,
	@GameID INT
AS

SELECT PGS.PlayerGameStatisticsID, PGS.SchoolID, PGS.Points, PGS.[3PT], PGS.FGM, PGS.FGA, PGS.Rebounds, PGS.[Minutes]
FROM Basketball.PlayerGameStatistics PGS
WHERE PGS.PlayerID = @PlayerID AND PGS.GameID = @GameID AND PGS.IsDeleted = 0;