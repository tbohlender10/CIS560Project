CREATE OR ALTER PROCEDURE Basketball.CountUpsetsBySeed
AS

SELECT SH.Seed - SL.Seed AS SeedDifferential,
	SUM(IIF(SH.Seed - SL.Seed >= 0, 1, 0)) AS NumberOfGamesWithSeedDifferential
	FROM Basketball.School SH
		INNER JOIN Basketball.GameSchool W ON SH.SchoolID = W.SchoolID
		INNER JOIN Basketball.GameSchool L ON L.GameID = W.GameID AND L.Score < W.Score
		INNER JOIN Basketball.School SL ON L.SchoolID = SL.SchoolID
	WHERE SH.Seed - SL.Seed > 0
	GROUP BY SH.Seed - SL.Seed
	ORDER BY SeedDifferential ASC;
GO