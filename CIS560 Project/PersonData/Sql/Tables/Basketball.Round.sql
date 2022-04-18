﻿IF OBJECT_ID(N'Basketball.[Round]') IS NULL
BEGIN
   CREATE TABLE Basketball.[Round]
	(
		RoundID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		[Name] NVARCHAR(64) NOT NULL

		UNIQUE([Name])
	)
END;
