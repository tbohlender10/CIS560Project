CREATE OR ALTER PROCEDURE Basketball.UpdatePlayerGameStatistics
	@GameID int,
	@PlayerID int,
	@SchoolID int,
	@Points int,
	@FGM int,
	@FGA int,
	@Rebounds int,
	@Minutes int
AS

UPDATE Basketball.PlayerGameStatistics
SET Points = @Points,
	FGM = @FGM,
	FGA = @FGA,
	Rebounds = @Rebounds,
	[Minutes] = @Minutes
WHERE GameID = @GameID AND PlayerID = @PlayerID AND SchoolID = @SchoolID
GO