IF OBJECT_ID(N'Basketball.Region') IS NULL
BEGIN
    CREATE TABLE Basketball.Region
    (
	    RegionID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	    [Name] NVARCHAR(64) NOT NULL

        UNIQUE([Name])
    );
END;
