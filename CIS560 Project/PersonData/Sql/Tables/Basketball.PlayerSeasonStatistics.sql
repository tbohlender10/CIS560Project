IF OBJECT_ID(N'Basketball.PlayerSeasonStatistics') IS NULL
BEGIN
   CREATE TABLE Basketball.PlayerSeasonStatistics
   (
		PlayerSeasonStatisticsID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
		PlayerID INT NOT NULL FOREIGN KEY
			REFERENCES Basketball.Player(PlayerID),
		PPG INT NOT NULL,
		[3PT] INT NOT NULL,
		FGM INT NOT NULL,
		FGA INT NOT NULL,
		Rebounds INT NOT NULL,
		[Minutes] INT NOT NULL,
		IsDeleted INT NOT NULL DEFAULT(0) CHECK(IsDeleted = 0 OR IsDeleted = 1)

		UNIQUE(PlayerID)
   );
END;
