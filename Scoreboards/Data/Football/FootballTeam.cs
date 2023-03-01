using System.Drawing;

namespace Scoreboards.Data.Football
{
    public class FootballTeam
    {
        public Uri? Logo { get; set; }
        public string AccentColorHex { get; set; } = "#dd0000";
        public string Name { get; set; } = "Undefined";
        public int Score { get; set; } = 0;

        public FootballStats Stats { get; set; } = new FootballStats();

        public List<FootballPlayer> Players { get; set; } = new List<FootballPlayer>();

        public override string ToString()
        {
            return this.Name+ " " + Score + "";
        }
    }
}
