namespace Scoreboards.Data.Football
{
    public class FootballTeam
    {
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
