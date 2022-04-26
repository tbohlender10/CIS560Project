CREATE OR ALTER PROCEDURE Basketball.UpdateGameScore
	@GameID int,
	@SchoolID int,
	@Score INT
AS

UPDATE Basketball.GameSchool 
SET Score = @Score
WHERE GameID = @GameID AND SchoolID = @SchoolID AND IsDeleted = 0;
GO
