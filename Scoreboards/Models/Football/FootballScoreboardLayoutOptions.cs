namespace Scoreboards.Models.Football
{
    public class FootballScoreboardLayoutOptions
    {
        public bool ShowScore { get; set; } = true;
        public bool ShowClock { get; set; } = true;
        public bool ShowTeamNames { get; set; } = false;
        public bool ShowTeamLogos { get; set; } = true;
        public bool ShowLineups { get; set; } = true;
        public bool ShowStats { get; set; } = false;
    }
}
