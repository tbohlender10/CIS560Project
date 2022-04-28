--Top player points per game
--CTE and then join with player table to get player info and school info and then join to region
CREATE OR ALTER PROCEDURE Basketball.FetchTopPPG
AS
WITH SourceCte(PlayerID, TotalPoints, GameCount, PPG) AS
(
	SELECT PGS.PlayerID, SUM(PGS.Points), COUNT(PGS.GameID) AS GameCount,
		1.0*SUM(PGS.Points) / COUNT(PGS.GameID) AS PPG
	FROM Basketball.PlayerGameStatistics PGS
	GROUP BY PGS.PlayerID
)
SELECT TOP(10) P.PlayerID, S.[Name] AS SchoolName, P.[Name] AS PlayerName, C.TotalPoints, C.GameCount, C.PPG
FROM SourceCte C
INNER JOIN Basketball.Player P ON C.PlayerID = P.PlayerID
INNER JOIN Basketball.School S ON P.SchoolID = S.SchoolID
ORDER BY C.PPG DESC
GO
