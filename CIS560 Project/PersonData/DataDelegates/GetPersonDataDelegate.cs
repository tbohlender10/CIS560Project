using DataAccess;
using PersonData.Models;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class GetPersonDataDelegate : DataReaderDelegate<Player>
   {
      private readonly string email;

      public GetPersonDataDelegate(string email)
         : base("Person.GetPerson")
      {
         this.email = email;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command);

         command.Parameters.AddWithValue("Email", email);
      }

      public override Player Translate(SqlCommand command, IDataRowReader reader)
      {
         if (!reader.Read())
            return null;

         return new Player(
            reader.GetInt32("PersonId"),
            reader.GetString("FirstName"),
            reader.GetString("LastName"),
            email);
      }
   }
}