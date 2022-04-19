CREATE OR ALTER PROCEDURE Basketball.RetrieveGamesForSchool
   @SchoolID INT
AS

SELECT G.GameID, G.DateTimeInfo, G.RoundID
FROM Basketball.Game G
INNER JOIN Basketball.GameSchool GS ON G.GameID = GS.GameID
INNER JOIN Basketball.School S ON S.SchoolID = GS.SchoolID
WHERE S.SchoolID = SchoolID
GO
