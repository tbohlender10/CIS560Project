﻿CREATE OR ALTER PROCEDURE Basketball.FetchPlayer
   @PlayerID INT
AS

SELECT P.SchoolID, P.[Name], P.Number, P.Grade, P.Position
FROM Basketball.Player P
WHERE P.PlayerID = @PlayerID;
GO
