﻿using DataAccess;
using PersonData.Models;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class RetrievePlayersForSchoolDataDelegate : DataReaderDelegate<IReadOnlyList<Player>>
   {
      private readonly int SchoolID;

      public RetrievePlayersForSchoolDataDelegate(int schoolID)
         : base("Basketball.RetrievePlayersForSchool") //stored procedure
      {
         SchoolID = schoolID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("SchoolID", SchoolID);
      }
      public override IReadOnlyList<Player> Translate(SqlCommand command, IDataRowReader reader)
      {
         var players = new List<Player>();

         while (reader.Read())
         {
                players.Add(new Player(
                reader.GetInt32("PlayerID"),
                SchoolID,
                reader.GetString("[Name]"),
                reader.GetString("Grade")));
         }

         return players;
      }
   }
}