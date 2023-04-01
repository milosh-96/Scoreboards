using Scoreboards.Data.Baseball;
using Scoreboards.Data.Football;

namespace Scoreboards.Features.Baseball
{
    public class BaseballScoreboardViewModel
    {
        public BaseballGame Game {get;set;} = new BaseballGame();
        public BaseballTeam  HomeTeam { get; set; } = new BaseballTeam()
        {
        };
        public BaseballTeam  AwayTeam { get; set; } = new BaseballTeam();

       


    }
}
