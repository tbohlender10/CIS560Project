--Number of Games with Certain Point-Differentials
CREATE OR ALTER PROCEDURE BASKETBALL.FetchPointDiff

AS

SELECT 
	GSW.Score - GSL.Score AS PointsDifferential, 
	SUM(IIF(GSW.Score - GSL.Score >= 1, 1, 0)) AS NumberOfGames
FROM Basketball.GameSchool GSW
	INNER JOIN Basketball.GameSchool GSL ON GSW.GameID = GSL.GameID AND GSW.Score > GSL.Score
GROUP BY GSW.Score - GSL.Score
ORDER BY NumberOfGames DESC, GSW.Score - GSL.Score DESC;
GO