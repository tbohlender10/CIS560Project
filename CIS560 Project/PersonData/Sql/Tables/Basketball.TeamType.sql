﻿IF OBJECT_ID(N'Basketball.TeamType') IS NULL
BEGIN
   CREATE TABLE Basketball.TeamType
	(
		TeamTypeID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		TeamType NVARCHAR(64) NOT NULl

		UNIQUE(TeamType)
	)
END;