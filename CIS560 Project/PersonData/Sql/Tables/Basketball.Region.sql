IF OBJECT_ID(N'Basketball.Region') IS NULL
BEGIN
    CREATE TABLE Basketball.Region
    (
	RegionID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	[Name] NVARCHAR(64) NOT NULL
    );
END;

/****************************
 * Unique Constraints
 ****************************/

IF NOT EXISTS
   (
      SELECT *
      FROM sys.key_constraints kc
      WHERE kc.parent_object_id = OBJECT_ID(N'Basketball.Region')
         AND kc.[name] = N'UK_Basketball_Region_Name'
   )
BEGIN
   ALTER TABLE Basketball.Region
   ADD CONSTRAINT [UK_Basketball_Region_Name] UNIQUE NONCLUSTERED
   (
      [Name] ASC
   )
END;
