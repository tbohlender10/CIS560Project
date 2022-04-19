CREATE OR ALTER PROCEDURE Basketball.RetrieveGamesForPlayer
   @PlayerID INT
AS

SELECT P.SchoolID, P.[Name], P.Grade
FROM Basketball.Games
WHERE P.PersonId = @PlayerID;
GO
