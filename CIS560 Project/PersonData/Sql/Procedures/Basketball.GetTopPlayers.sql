CREATE OR ALTER PROCEDURE Basketball.GetTopPlayers
   @PlayerID INT
AS

SELECT P.SchoolID, P.[Name], P.Grade
FROM Basketball.Player
WHERE P.PersonId = @PlayerID;
GO
