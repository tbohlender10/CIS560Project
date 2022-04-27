CREATE OR ALTER PROCEDURE Basketball.DeleteGameStatistics
	@GameID int
AS

UPDATE Basketball.GameSchool
SET 
	Score = -1,
	IsDeleted = 1
WHERE GameID = @GameID
GO