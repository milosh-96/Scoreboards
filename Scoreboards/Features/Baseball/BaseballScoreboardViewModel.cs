using Scoreboards.Data.Baseball;
using Scoreboards.Data.Football;

namespace Scoreboards.Features.Baseball
{
    public class BaseballScoreboardViewModel
    {
        public BaseballPitcher Pitcher { get; set; } = new BaseballPitcher();

        public BaseballGame Game { get; set; } = new BaseballGame();
        public BaseballTeam HomeTeam { get; set; } = new BaseballTeam() { AccentColorHex="#003366"};
        public BaseballTeam AwayTeam { get; set; } = new BaseballTeam();


    }
}
