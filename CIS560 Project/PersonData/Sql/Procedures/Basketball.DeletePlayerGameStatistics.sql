-- This procedure deletes a certain player's statistics with GameID, PlayerID, and SchoolID in the table PlayerGameStatistics.
CREATE OR ALTER PROCEDURE Basketball.DeletePlayerGameStatistics
	@GameID int,
	@PlayerID int,
	@SchoolID int
AS

UPDATE Basketball.PlayerGameStatistics
SET 
	IsDeleted = 1
WHERE GameID = @GameID AND PlayerID = @PlayerID AND SchoolID = @SchoolID AND IsDeleted = 0
GO