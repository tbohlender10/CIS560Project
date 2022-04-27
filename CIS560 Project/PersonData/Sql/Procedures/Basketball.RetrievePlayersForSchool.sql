-- This procedure retrieves all players' information for a school from the Player table.
CREATE OR ALTER PROCEDURE Basketball.RetrievePlayersForSchool
   @SchoolID INT
AS

SELECT P.PlayerID, P.[Name], P.Number, P.Grade, P.Position
FROM Basketball.Player P
WHERE P.SchoolID = @SchoolID AND P.IsDeleted = 0;
GO