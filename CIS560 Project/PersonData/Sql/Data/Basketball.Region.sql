DECLARE @RegionStaging TABLE
(
   RegionID INT NOT NULL PRIMARY KEY,
   [Name] NVARCHAR(64) NOT NULL UNIQUE
);

/***************************** Modify values here *****************************/

INSERT @RegionStaging(RegionID, [Name])
VALUES
   (1, N'West'),
   (2, N'East'),
   (3, N'South'),
   (4, N'MidWest');

/******************************************************************************/

MERGE Basketball.Region R
USING @RegionStaging S ON S.RegionID = R.RegionID
WHEN MATCHED AND S.[Name] <> R.[Name] THEN
   UPDATE
   SET [Name] = S.[Name]
WHEN NOT MATCHED THEN
   INSERT(RegionID, [Name])
   VALUES(S.RegionID, S.[Name]);
