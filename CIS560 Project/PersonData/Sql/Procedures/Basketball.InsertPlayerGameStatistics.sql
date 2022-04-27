-- This procedure inserts a player's game statistics into the PlayerGameStatistics table.
CREATE OR ALTER PROCEDURE Basketball.InsertPlayerGameStatistics
	@DateTimeInfo DATETIMEOFFSET,
	@School NVARCHAR(64),
	@PlayerName NVARCHAR(128),
	@Points INT,
	@ThreePoints INT,
	@FGM INT,
	@FGA INT,
	@Rebounds INT,
	@Minutes INT
AS

WITH SourceCte(GameID, PlayerID, SchoolID, Points, ThreePoints, FGM, FGA, Rebounds, [Minutes]) AS
(
	SELECT G.GameID, P.PlayerID, S.SchoolID, GamePlayerInfo.Points, GamePlayerInfo.ThreePoints,
		GamePlayerInfo.FGM, GamePlayerInfo.FGA, GamePlayerInfo.Rebounds, GamePlayerInfo.[Minutes]
	FROM
	(
		VALUES
		(@DateTimeInfo, @PlayerName, @School, @Points, @ThreePoints, @FGM, @FGA, @Rebounds, @Minutes)
	) GamePlayerInfo(DateTimeInfo, PlayerName, School, Points, ThreePoints, FGM, FGA, Rebounds, [Minutes])
	INNER JOIN Basketball.Game G ON G.DateTimeInfo = GamePlayerInfo.DateTimeInfo
	INNER JOIN Basketball.Player P ON P.[Name] = GamePlayerInfo.PlayerName
	INNER JOIN Basketball.School S ON S.[Name] = GamePlayerInfo.School
)

INSERT Basketball.PlayerGameStatistics(GameID, PlayerID, SchoolID, Points, [3PT], FGM, FGA, Rebounds, [Minutes])
SELECT C.GameID, C.PlayerID, C.SchoolID, C.Points, C.ThreePoints, C.FGM, C.FGA, C.Rebounds, C.[Minutes]
FROM SourceCte C;
GO