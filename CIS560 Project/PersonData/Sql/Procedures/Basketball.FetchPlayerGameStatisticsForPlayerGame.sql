CREATE OR ALTER PROCEDURE Basketball.FetchPlayerGameStatisticsForPlayerGame
	@PlayerID INT,
	@GameID INT
AS

SELECT PGS.PlayerGameStatisticsID, PGS.SchoolID, PGS.Points, PGS.[3PT], PGS.FGM, PGS.FGA, PGS.Rebounds, PGS.[Minutes]
FROM Basketball.PlayerGameStatistics PGS
WHERE PGS.PlayerID = @PlayerID AND PGS.GameID = @GameID;