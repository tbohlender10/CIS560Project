Param(
   [string] $Server = "(localdb)\MSSQLLocalDb",
   [string] $Database = "CIS560Project"
)

#THIS IS THE PROJECT TO WORK ON!!!

# This script requires the SQL Server module for PowerShell.
# The below commands may be required.

# To check whether the module is installed.
# Get-Module -ListAvailable -Name SqlServer;

# Install the SQL Server Module
# Install-Module -Name SqlServer -Scope CurrentUser

$CurrentDrive = (Get-Location).Drive.Name + ":"

Write-Host ""
Write-Host "Rebuilding database $Database on $Server..."

<#
   If on your local machine, you can drop and re-create the database.
#>
& ".\Scripts\DropDatabase.ps1" -Database $Database
& ".\Scripts\CreateDatabase.ps1" -Database $Database

<#
   If on the department's server, you don't have permissions to drop or create databases.
   In this case, maintain a script to drop all tables.
#>
#Write-Host "Dropping tables..."
#Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\DropTables.sql"

Write-Host "Creating schema..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Schemas\Basketball.sql"

Write-Host "Creating tables..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.Round.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.Region.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.TeamType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.School.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.Player.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.PlayerSeasonStatistics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.Game.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.GameSchool.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Tables\Basketball.PlayerGameStatistics.sql"

Write-Host "Stored procedures..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.FetchPlayer.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.FetchPlayerSeasonStatistics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.GetSchool.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.RetrieveGamesForSchool.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.RetrieveAllGames.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.RetrievePlayersForSchool.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.RetrieveSchools.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.FetchSchoolsWithNumberOfWins.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.FetchGameInfoForSchool.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdateGameScore.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdatePlayerGrade.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdatePlayerNumber.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdatePlayerName.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdatePlayerPosition.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdatePlayerGameStatistics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.InsertPlayerGameStatistics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.InsertGameSchoolStatistics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.RetrieveSchoolsForGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.FetchPlayerGameStatisticsForPlayerGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.RetrieveHomeSchoolForGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.RetrieveGuestSchoolForGame.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdateSchoolCoach.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.DeleteGameStatistics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.DeletePlayerGameStatistics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdateSchoolCoach.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdateSchoolSeed.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Procedures\Basketball.UpdateSchoolRegion.sql"

Write-Host "Inserting data..."
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Basketball.Round.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Basketball.Region.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Basketball.TeamType.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Basketball.School.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Basketball.Player.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Basketball.Game.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Basketball.PlayerGameStatistics.sql"
Invoke-SqlCmd -ServerInstance $Server -Database $Database -InputFile "PersonData\Sql\Data\Basketball.GameSchool.sql"

Write-Host "Rebuild completed."
Write-Host ""

Set-Location $CurrentDrive
