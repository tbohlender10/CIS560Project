﻿using DataAccess;
using PersonData.Models;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class FetchPlayerDataDelegate : DataReaderDelegate<Player>
   {
      private readonly int PlayerID;

      public FetchPlayerDataDelegate(int playerID)
         : base("Person.FetchPlayer") //what is this??
      {
         PlayerID = playerID;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("PlayerID", PlayerID);
      }

      public override Player Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            throw new RecordNotFoundException(PlayerID.ToString());

         return new Player(PlayerID,
            reader.GetInt32("SchoolID"), //is this what I need to do??
            reader.GetString("[Name]"),
            reader.GetString("Grade"));
      }
   }
}