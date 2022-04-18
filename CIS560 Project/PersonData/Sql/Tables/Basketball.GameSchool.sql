﻿IF OBJECT_ID(N'Basketball.GameSchool') IS NULL
BEGIN
   CREATE TABLE Basketball.GameSchool
   (
	GameID INT NOT NULL FOREIGN KEY
		REFERENCES Basketball.Game(GameID),
	SchoolID INT NOT NULL FOREIGN KEY
		REFERENCES Basketball.School(SchoolID),
	TeamTypeID INT NOT NULL FOREIGN KEY
		REFERENCES Basketball.TeamType(TeamTypeID),

	CONSTRAINT PK_Basketball_GameSchool_GameIDSchoolID PRIMARY KEY
	(
		GameID,
		SchoolID
	)
   );
END
