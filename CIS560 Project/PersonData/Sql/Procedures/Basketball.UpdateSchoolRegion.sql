-- This procedure updates the region of school in the School table.
CREATE OR ALTER PROCEDURE Basketball.UpdateSchoolRegion
	@SchoolID int,
	@RegionID int
AS

UPDATE Basketball.School
SET RegionID = @RegionID
WHERE SchoolID = @SchoolID AND IsDeleted = 0
GO