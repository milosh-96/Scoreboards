using Scoreboards.Data;
using Scoreboards.Data.Football;
using System;
using System.Drawing;

namespace Scoreboards.Features.Football
{
    
    public class FootballScoreboardViewModel
    {
        public FootballEventBus Event { get; set; } = new FootballEventBus();

        public FootballScoreboardLayoutOptions LayoutOptions { get; set; } = new FootballScoreboardLayoutOptions();


        public FootballTeam HomeTeam { get; set; } = new FootballTeam()
        {

            AccentColorHex = "#003366",
            Players = Enumerable.Range(1, 11).Select(x => new FootballPlayer() { Position = "Goalkeeper", ShirtNumber = x }).ToList()
        };

        public FootballTeam AwayTeam { get; set; } = new FootballTeam()
        {
            AccentColorHex = "#dd0000",
            Players = Enumerable.Range(1, 11).Select(x => new FootballPlayer() { Position = "Goalkeeper", ShirtNumber = x }).ToList()

        };


        //set clock to 89 min for testing
        public Clock Clock { get; set; } = new Clock();

        public string GetClockString()
        {
            var timeSpan = TimeSpan.FromMilliseconds(Clock.Milliseconds);
            return string.Format("{0:D2}:{1:D2}",
                (int)timeSpan.TotalMinutes,
                timeSpan.Seconds);

        }
        public string GetMatchTitleWithScore()
        {
            return string.Format(
                "{0} {1}:{3} {2}",
                HomeTeam.Name, HomeTeam.Score,
                AwayTeam.Name, AwayTeam.Score);

        }
    }
}
