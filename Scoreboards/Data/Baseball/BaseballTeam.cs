using Scoreboards.Data.Football;

namespace Scoreboards.Data.Baseball
{
    public class BaseballTeam : Team
    {
        public BaseballTeamStats Stats { get; set; } = new BaseballTeamStats()
        {
            Linescore = Enumerable.Range(1, 12).Select(x => new Halfinning()).ToList()
        };

        public BaseballPitcher CurrentPitcher { get; set; } = new BaseballPitcher();

    }
}
