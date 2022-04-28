-- This procedure fetches a player's seasonal stats, including their PPG, 3-pointer percentage, FGM, FGA, rebounds, and minutes.
CREATE OR ALTER PROCEDURE Basketball.FetchPlayerSeasonStatistics
   @PlayerID INT
AS

SELECT PSS.PlayerSeasonStatisticsID, PSS.PPG, PSS.[3PT], PSS.FGM, PSS.FGA, PSS.Rebounds, PSS.[Minutes]
FROM Basketball.PlayerSeasonStatistics PSS
WHERE PSS.PlayerID = @PlayerID AND PSS.IsDeleted = 0;
GO