CREATE OR ALTER PROCEDURE Basketball.UpdatePlayerGameStatistics
	@GameID int,
	@PlayerID int,
	@SchoolID int,
	@Points int,
	@ThreePoints int,
	@FGM int,
	@FGA int,
	@Rebounds int,
	@Minutes int
AS

WITH SourceCte(GameID, PlayerID, SchoolID, Points, ThreePoints, FGM, FGA, Rebounds, [Minutes]) AS
(
	SELECT Info.GameID, Info.PlayerID, Info.SchoolID, Info.Points, Info.ThreePoints, Info.FGM, 
		Info.FGA, Info.Rebounds, Info.[Minutes]
	FROM
	(
		VALUES
		(@GameID, @PlayerID, @SchoolID, @Points, @ThreePoints, @FGM, @FGA, @Rebounds, @Minutes)
	) Info(GameID, PlayerID, SchoolID, Points, ThreePoints, FGM, FGA, Rebounds, [Minutes])
)

MERGE Basketball.PlayerGameStatistics T
USING SourceCte S ON S.GameID = T.GameID AND S.PlayerID = T.PlayerID AND S.SchoolID = T.SchoolID
WHEN MATCHED THEN
	UPDATE 
	SET Points = @Points,
		[3PT] = @ThreePoints,
		FGM = @FGM,
		FGA = @FGA,
		Rebounds = @Rebounds,
		[Minutes] = @Minutes
WHEN NOT MATCHED THEN
	INSERT(GameID, PlayerID, SchoolID, Points, FGM, FGA, Rebounds, [Minutes])
	VALUES(@GameiD, @PlayerID, @SchoolID, @Points, @FGM, @FGA, @Rebounds, @Minutes);
GO