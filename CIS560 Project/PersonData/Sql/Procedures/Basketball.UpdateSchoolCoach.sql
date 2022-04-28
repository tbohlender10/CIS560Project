-- This procedure updates the coach information for a school in the School table.
CREATE OR ALTER PROCEDURE Basketball.UpdateSchoolCoach
	@SchoolID int,
	@Coach NVARCHAR(64)
AS

UPDATE Basketball.School
SET Coach = @Coach
WHERE SchoolID = @SchoolID AND IsDeleted = 0
GO