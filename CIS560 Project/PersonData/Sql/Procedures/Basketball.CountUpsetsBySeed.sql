--This aggregating query calculates upset differentials (difference in a lower seed beeting a higher seed)
-- returns each differential with how many games with that differential in seeds there were, for example
-- if there were 4 games where the higher seed minus the lower seed = 4 then the number of games with
-- the seed differential 4 would be 4
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