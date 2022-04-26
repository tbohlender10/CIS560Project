CREATE OR ALTER PROCEDURE Basketball.FetchGameInfoForSchool
	@SchoolName NVARCHAR(64)
AS

SELECT SH.[Name] AS HomeSchool, SG.[Name] AS GuestSchool, GSH.Score AS HomeSchoolScore, GSG.Score AS GuestSchoolScore,
	IIF(GSH.Score > GSG.Score, SH.[Name], SG.[Name]) AS WinningSchool
FROM Basketball.School SH
   INNER JOIN Basketball.GameSchool GSH ON GSH.SchoolId = SH.SchoolId
   INNER JOIN Basketball.GameSchool GSG ON GSG.GameId = GSH.GameId
      AND GSG.TeamTypeId <> GSH.TeamTypeId 
   INNER JOIN Basketball.School SG ON SG.SchoolId = GSG.SchoolId 
WHERE SH.[Name] = @SchoolName AND SH.IsDeleted = 0;
GO
