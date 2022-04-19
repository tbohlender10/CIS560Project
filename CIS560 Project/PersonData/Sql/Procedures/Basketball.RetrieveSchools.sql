CREATE OR ALTER PROCEDURE Basketball.RetrieveSchools
AS

SELECT S.SchoolID, S.[Name], S.Coach, S.Seed, S.RegionID
FROM Basketball.School S;
GO
