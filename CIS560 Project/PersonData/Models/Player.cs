using System;

namespace PersonData.Models
{
   public class Player
   {
        public int PlayerID { get; }

        public int SchoolID { get; } = 0;

        public string Name { get; }
        
        public string Grade { get; }

      public Player(int playerID, int schoolID, string name, string grade)
      {
            PlayerID = playerID;
            SchoolID = schoolID;
            Name = name;
            Grade = grade;
      }
   }
}
