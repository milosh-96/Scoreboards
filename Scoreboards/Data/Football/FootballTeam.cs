using System.Drawing;

namespace Scoreboards.Data.Football
{
    public class FootballTeam : Team
    {
       
        public int Score { get; set; } = 0;

        public FootballStats Stats { get; set; } = new FootballStats();

        public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();
        public List<FootballScorer> Scorers { get; set; } = new List<FootballScorer>();
        public List<FootballPlayer> Bookings { get; set; } = new List<FootballPlayer>();

        public override string ToString()
        {
            return this.Name+ " " + Score + "";
        }
    }
}
