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