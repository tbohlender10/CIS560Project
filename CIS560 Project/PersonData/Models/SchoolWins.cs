using System;

namespace PersonData.Models
{

   public class SchoolWins
   {
        public int SchoolID { get; }

        public string Name { get; }

        public int Wins { get; }
      
        public SchoolWins(int schoolID, string name, int wins)
        {
            SchoolID = schoolID;
            Name = name;
            Wins = wins;
        }

        public override string ToString()
        {
            return Name + ": " + Wins.ToString();
        }
    }
}
