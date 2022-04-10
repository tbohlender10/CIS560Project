using DataAccess;
using PersonData.Models;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace PersonData.DataDelegates
{
   internal class RetrievePersonsDataDelegate : DataReaderDelegate<IReadOnlyList<Player>>
   {
      public RetrievePersonsDataDelegate()
         : base("Person.RetrievePersons")
      {
      }

      public override IReadOnlyList<Player> Translate(SqlCommand command, IDataRowReader reader) //don't have to get ordinals
      {
         var persons = new List<Player>();

         while (reader.Read())
         {
            persons.Add(new Player(
               reader.GetInt32("PersonId"),
               reader.GetString("FirstName"),
               reader.GetString("LastName"),
               reader.GetString("Email")));
         }

         return persons;
      }
   }
}