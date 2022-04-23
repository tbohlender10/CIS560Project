CREATE OR ALTER PROCEDURE Basketball.UpdateGameScore
	@SchoolName NVARCHAR(64),
	@GameID INT,
	@TeamType NVARCHAR(64),
	@Score INT
AS

WITH SourceCte(GameID, SchoolID, TeamTypeID, Score) AS
(
	SELECT GameInfo.GameID, S.SchoolID, TT.TeamTypeID, GameInfo.Score
	FROM
	(
		VALUES
		(@GameID, @SchoolName, @TeamType, @Score)
	) GameInfo(GameID, SchoolName, TeamType, Score)
	INNER JOIN Basketball.School S ON S.[Name] = GameInfo.SchoolName
	INNER JOIN Basketball.TeamType TT ON TT.TeamType = GameInfo.TeamType
)
MERGE Basketball.GameSchool GS
USING SourceCte S ON S.GameID = GS.GameID 
	AND S.SchoolID = GS.GameID
WHEN MATCHED AND (GS.Score <> S.Score
		OR GS.Score IS NULL AND S.Score IS NOT NULL
		OR GS.Score IS NOT NULL AND S.Score IS NULL) THEN
	UPDATE 
		SET Score = S.Score
WHEN NOT MATCHED THEN
   INSERT(GameID, SchoolID, TeamTypeID, Score)
   VALUES(S.GameID, S.SchoolID, S.TeamTypeID, S.Score);
GO
