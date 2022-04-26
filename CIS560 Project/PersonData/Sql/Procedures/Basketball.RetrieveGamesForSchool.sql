CREATE OR ALTER PROCEDURE Basketball.RetrieveGamesForSchool
   @School NVARCHAR(64)
AS

SELECT G.GameID, G.DateTimeInfo, G.RoundID
FROM Basketball.Game G
INNER JOIN Basketball.GameSchool GS ON G.GameID = GS.GameID
INNER JOIN Basketball.School S ON S.SchoolID = GS.SchoolID
WHERE S.[Name] = @School AND S.IsDeleted = 0 AND G.IsDeleted = 0 AND GS.IsDeleted = 0;
GO
