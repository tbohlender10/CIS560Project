﻿IF OBJECT_ID(N'Basketball.Game') IS NULL
BEGIN
   CREATE TABLE Basketball.Game
	(
		GameID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		DateTimeInfo DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
		RoundID INT NOT NULL FOREIGN KEY
			REFERENCES Basketball.[Round](RoundID)
	)
END;
