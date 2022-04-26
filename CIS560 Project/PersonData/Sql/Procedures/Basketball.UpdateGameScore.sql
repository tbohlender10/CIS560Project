CREATE OR ALTER PROCEDURE Basketball.UpdateGameScore
	@SchoolID int,
	@DateTimeInfo DATETIMEOFFSET,
	@TeamTypeID int,
	@Score INT
AS

WITH SourceCte(GameID, SchoolID, TeamTypeID, Score) AS
(
	SELECT G.GameID, GameInfo.SchoolID, GameInfo.TeamTypeID, GameInfo.Score
	FROM
	(
		VALUES
		(@DateTimeInfo, @SchoolID, @TeamTypeID, @Score)
	) GameInfo(DateTimeInfo, SchoolID, TeamTypeID, Score)
	INNER JOIN Basketball.Game G ON G.DateTimeInfo = GameInfo.DateTimeInfo
)
MERGE Basketball.GameSchool GS
USING SourceCte S ON S.GameID = GS.GameID 
	AND S.SchoolID = GS.GameID AND GS.IsDeleted = 0
WHEN MATCHED AND (GS.Score <> S.Score
		OR GS.Score IS NULL AND S.Score IS NOT NULL
		OR GS.Score IS NOT NULL AND S.Score IS NULL) THEN
	UPDATE 
		SET Score = S.Score
WHEN NOT MATCHED THEN
   INSERT(GameID, SchoolID, TeamTypeID, Score)
   VALUES(S.GameID, S.SchoolID, S.TeamTypeID, S.Score);
GO
