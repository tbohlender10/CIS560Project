using PersonData.Models;
using DataAccess;
using System.Data;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class CreatePersonDataDelegate : NonQueryDataDelegate<Player>
   {
      public readonly string firstName;
      public readonly string lastName;
      private readonly string email;

      public CreatePersonDataDelegate(string firstName, string lastName, string email)
         : base("Person.CreatePerson") //base calss is just name of stored procedure
      {
         this.firstName = firstName;
         this.lastName = lastName;
         this.email = email;
      }

      public override void PrepareCommand(SqlCommand command)
      {
         base.PrepareCommand(command); //if not parameters we don't need to provide this, override

         command.Parameters.AddWithValue("FirstName", firstName);
         command.Parameters.AddWithValue("LastName", lastName);
         command.Parameters.AddWithValue("Email", email);

         var p = command.Parameters.Add("PersonId", SqlDbType.Int);
         p.Direction = ParameterDirection.Output;
      }

      public override Player Translate(SqlCommand command)
      {
         return new Player((int)command.Parameters["PersonId"].Value, firstName, lastName, email);
      }
   }
}