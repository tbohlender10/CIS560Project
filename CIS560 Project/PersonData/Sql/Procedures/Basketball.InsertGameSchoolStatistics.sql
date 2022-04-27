CREATE OR ALTER PROCEDURE Basketball.InsertGameSchoolStatistics
	@GameID int,
	@SchoolID int,
	@TeamTypeID int,
	@Score int
AS

WITH SourceCte(GameID, SchoolID, TeamTypeID, Score) AS
(
	SELECT GameInfo.GameID, GameInfo.SchoolID, GameInfo.TeamTypeID, GameInfo.Score
	FROM
	(
		VALUES
		(@GameID, @SchoolID, @TeamTypeID, @Score)
	) GameInfo(GameID, SchoolID, TeamTypeID, Score)
)
MERGE Basketball.GameSchool T
USING SourceCte S ON S.GameID = T.GameID AND S.SchoolID = T.SchoolID AND S.TeamTypeID = T.TeamTypeID
WHEN MATCHED THEN
	UPDATE
	SET Score = S.Score,
		IsDeleted = 0
WHEN NOT MATCHED THEn
INSERT (GameID, SchoolID, TeamTypeID, Score)
VALUES(s.GameID, S.SchoolID, S.TeamTypeID, S.Score);
GO