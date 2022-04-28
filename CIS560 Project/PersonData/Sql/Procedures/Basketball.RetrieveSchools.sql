-- This procedure simply retrieves information about all the school, including its ID, name, coach, seed, and regionID.
CREATE OR ALTER PROCEDURE Basketball.RetrieveSchools
AS

SELECT S.SchoolID, S.[Name], S.Coach, S.Seed, S.RegionID
FROM Basketball.School S 
WHERE S.IsDeleted = 0;
GO