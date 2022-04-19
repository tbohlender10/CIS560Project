using System;

namespace PersonData.Models
{
   public class Player
   {
        public int PlayerID { get; }

        public int SchoolID { get; } = 0;

        public string Name { get; }

        public int Number { get; }
        
        public string Grade { get; }

      public Player(int playerID, int schoolID, string name, int number, string grade)
      {
            PlayerID = playerID;
            SchoolID = schoolID;
            Name = name;
            Number = number;
            Grade = grade;
      }
   }
}
