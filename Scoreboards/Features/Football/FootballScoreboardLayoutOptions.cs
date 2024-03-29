﻿namespace Scoreboards.Features.Football
{
    public class FootballScoreboardLayoutOptions
    {
        public int LayoutPreset { get; set; } = 1;

        public bool ShowScore { get; set; } = true;
        public bool ShowClock { get; set; } = true;
        public bool ShowTeamNames { get; set; } = false;
        public bool ShowTeamLogos { get; set; } = true;
        public bool ShowLineups { get; set; } = true;
        public bool ShowStats { get; set; } = true;
    }
}
