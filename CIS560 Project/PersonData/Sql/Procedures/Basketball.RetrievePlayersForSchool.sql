CREATE OR ALTER PROCEDURE Basketball.RetrievePlayersForSchool
   @SchoolID INT
AS

SELECT P.PlayerID, P.[Name], P.Grade
FROM Basketball.Player P
WHERE P.SchoolID = @SchoolID;
GO