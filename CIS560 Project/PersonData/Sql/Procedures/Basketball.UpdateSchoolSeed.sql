CREATE OR ALTER PROCEDURE Basketball.UpdateSchoolSeed
	@SchoolID int,
	@Seed int
AS

UPDATE Basketball.School
SET Seed = @Seed
WHERE SchoolID = @SchoolID AND IsDeleted = 0
GO