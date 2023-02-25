using Scoreboards.Data.Football;
using System;

namespace Scoreboards.Models.Football
{
    public class FootballScoreboardViewModel
    {
        public FootballTeam HomeTeam { get; set; } = new FootballTeam();
        public FootballTeam AwayTeam { get; set; } = new FootballTeam();    


        public int Clock { get; set; } = 89*60;

        public string GetClockString()
        {
            var timeSpan = TimeSpan.FromSeconds(this.Clock);
            return String.Format("{0:D2}:{1:D2}",
                (int)timeSpan.TotalMinutes,
                timeSpan.Seconds);

        }
        public string GetMatchTitleWithScore()
        {
            return String.Format(
                "{0} {1}:{3} {2}",
                this.HomeTeam.Name, this.HomeTeam.Score,
                this.AwayTeam.Name, this.AwayTeam.Score);

        }
    }
}
