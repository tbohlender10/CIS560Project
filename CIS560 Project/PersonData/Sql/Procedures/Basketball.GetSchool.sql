CREATE OR ALTER PROCEDURE Basketball.GetSchool
   @SchoolID int
AS

SELECT S.[Name], S.Coach, S.Seed, S.RegionID
FROM Basketball.School S
WHERE S.SchoolID = @SchoolID AND S.IsDeleted = 0;
GO
