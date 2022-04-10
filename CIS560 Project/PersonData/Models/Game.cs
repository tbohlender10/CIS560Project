namespace PersonData.Models
{
   public class Game
    {
        public int GameID { get; }

        public int HomeSchoolID { get; }

        public int AwaySchoolID { get; }

        public int WinningSchoolID { get; set; }

        public Game(int gameID, int homeSchoolID, int awaySchoolID)
        {
            GameID = gameID;
            HomeSchoolID = homeSchoolID;
            AwaySchoolID = awaySchoolID;
        }
    }
}
