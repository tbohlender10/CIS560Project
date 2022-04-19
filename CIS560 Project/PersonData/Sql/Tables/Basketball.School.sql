﻿IF OBJECT_ID(N'Basketball.School') IS NULL
BEGIN
   CREATE TABLE Basketball.School
   (
    SchoolID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(64) NOT NULL,
	Coach NVARCHAR(64) NOT NULL,
	Seed INT NOT NULL,
	RegionID INT NOT NULL FOREIGN KEY
		REFERENCES Basketball.Region(RegionID)

	UNIQUE(Seed, RegionID)
   );
END
