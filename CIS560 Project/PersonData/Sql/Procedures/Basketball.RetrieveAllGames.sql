CREATE OR ALTER PROCEDURE Basketball.RetrieveAllGames
AS

SELECT G.GameID, G.DateTimeInfo, G.RoundID
FROM Basketball.Game G
GO
