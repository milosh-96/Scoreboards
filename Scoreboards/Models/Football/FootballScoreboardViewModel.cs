using Scoreboards.Data.Football;

namespace Scoreboards.Models.Football
{
    public class FootballScoreboardViewModel
    {
        public FootballTeam HomeTeam { get; set; } = new FootballTeam();
        public FootballTeam AwayTeam { get; set; } = new FootballTeam();

    

        public int Clock { get; set; } = 89*60;
    }
}
