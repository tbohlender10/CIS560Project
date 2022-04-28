-- Top upset games by seeds
CREATE OR ALTER PROCEDURE Basketball.FetchUpsetsBySeed

AS

SELECT
	SH.[Name] AS HighSeedName,
	SH.Seed AS HighSeed,
	SL.[Name] AS LowSeedName,
	SL.Seed AS LowSeed,
	SH.Seed - SL.Seed AS SeedDifferential
FROM Basketball.School SH
	INNER JOIN Basketball.GameSchool W ON SH.SchoolID = W.SchoolID
	INNER JOIN Basketball.GameSchool L ON L.GameID = W.GameID AND L.Score < W.Score
	INNER JOIN Basketball.School SL ON L.SchoolID = SL.SchoolID
GROUP BY SH.Name, SH.Seed, SL.Name, SL.Seed
HAVING SH.Seed - SL.Seed >= 1
ORDER BY SH.Seed - SL.Seed DESC;
GO