﻿IF OBJECT_ID(N'Basketball.PlayerGameStatistics') IS NULL
BEGIN
   CREATE TABLE Basketball.PlayerGameStatistics
	(
		PlayerGameStatisticsID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		PlayerID INT NOT NULL,
		GameID INT NOT NULL,
		SchoolID INT NOT NULL,
		Points INT NOT NULL,
		[3PT] INT NOT NULL,
		FGM INT NOT NULL,
		FGA INT NOT NULL,
		Rebounds INT NOT NULL,
		[Minutes] INT NOT NULL

		UNIQUE(PlayerID, GameID),

		CONSTRAINT FK_Basketball_PlayerGameStatistics_GameIDSchoolID FOREIGN KEY
		(
			GameID,
			SchoolID
		)
		REFERENCES Basketball.GameSchool
		(
			GameID,
			SchoolID
		),

		CONSTRAINT FK_Basketball_PlayerGameStatistics_PlayerIDSchoolID FOREIGN KEY
		(
			SchoolID,
			PlayerID
		)
		REFERENCES Basketball.Player
		(
			SchoolID,
			PlayerID
		)
	)
END;
