CREATE OR ALTER PROCEDURE Basketball.FetchSchoolsWithNumberOfWins
AS

SELECT S.SchoolID, S.[Name] AS School, COUNT(IIF(GS.Score > GSO.Score, 1, 0)) AS Wins
FROM Basketball.School S
   INNER JOIN Basketball.GameSchool GS ON GS.SchoolId = S.SchoolId
   INNER JOIN Basketball.GameSchool GSO ON GSO.GameId = GS.GameId
      AND GSO.TeamTypeId <> GS.TeamTypeId
GROUP BY S.SchoolID, S.[Name]
GO