-- This procedure updates the score of a game in the GameSchool table.
CREATE OR ALTER PROCEDURE Basketball.UpdateGameScore
	@GameID int,
	@SchoolID int,
	@Score INT
AS

UPDATE Basketball.GameSchool 
SET Score = @Score,
	IsDeleted = 0
WHERE GameID = @GameID AND SchoolID = @SchoolID
GO
