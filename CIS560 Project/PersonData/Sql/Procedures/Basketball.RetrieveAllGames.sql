CREATE OR ALTER PROCEDURE Basketball.RetrieveAllGames
AS

SELECT G.GameID, G.DateTimeInfo, G.RoundID
FROM Basketball.Game G
WHERE G.IsDeleted = 0;
GO
