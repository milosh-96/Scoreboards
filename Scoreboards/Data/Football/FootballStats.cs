using System.ComponentModel;

namespace Scoreboards.Data.Football
{
    public class FootballStats
    {
        [DisplayName("Posession (%)")]
        public int Posession { get; set; } = 0;
        public int Passes { get; set; } = 0;

        [DisplayName("Passes (completed)")]

        public int CompletedPasses { get; set; } = 0;
        public int Shots { get; set; } = 0;

        [DisplayName("Shots On Target")]
        public int ShotsOnTarget { get; set; } = 0;
        public int CornerKicks { get; set; } = 0;
        public int FreeKicks { get; set; } = 0;
        public int Penalties { get; set; } = 0;
        public int Fouls { get; set; } = 0;
        public int Offsides { get; set; } = 0;
        public int YellowCards { get; set; } = 0;
        public int RedCards { get; set; } = 0;
    }
}
