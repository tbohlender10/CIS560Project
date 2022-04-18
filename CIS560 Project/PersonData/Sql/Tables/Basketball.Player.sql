IF OBJECT_ID(N'Basketball.Player') IS NULL
BEGIN
   CREATE TABLE Basketball.Player
   (
    PlayerID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	SchoolID INT NOT NULL FOREIGN KEY
		REFERENCES Basketball.School(SchoolID),
	[Name] NVARCHAR(128) NOT NULL,
	Number INT NOT NULL,
	Grade NVARCHAR(64) NOT NULL

	UNIQUE(SchoolID, Number)
   );
END;
