using Scoreboards.Data.Baseball;
using Scoreboards.Data.Football;

namespace Scoreboards.Features.Baseball
{
    public class BaseballScoreboardViewModel
    {
        public BaseballPitcher Pitcher { get; set; } = new BaseballPitcher();

        public BaseballGame Game { get; set; } = new BaseballGame();
        public BaseballTeam HomeTeam { get; set; } = new BaseballTeam() { 
            Name = "New York Mets",
            Abbreviation = "NYM",
            Lineup = new List<BaseballPlayer>()
            {
                new BaseballPlayer(){FirstName="Brandon",LastName="Nimmo",Position=BaseballPositionsEnum.CenterFielder},
                new BaseballPlayer(){FirstName="Francisco",LastName="Lindor",Position=BaseballPositionsEnum.Shortstop},
                new BaseballPlayer(){FirstName="Jeff",LastName="McNeil",Position=BaseballPositionsEnum.SecondBaseman},
                new BaseballPlayer(){FirstName="Pete",LastName="Alonso",Position=BaseballPositionsEnum.FirstBaseman},
                new BaseballPlayer(){FirstName="Daniel",LastName="Vogelbach",Position=BaseballPositionsEnum.DesignatedHitter},
                new BaseballPlayer(){FirstName="Starling",LastName="Marte",Position=BaseballPositionsEnum.RightFielder},
                new BaseballPlayer(){FirstName="Brett",LastName="Batty",Position=BaseballPositionsEnum.ThirdBaseman},
                new BaseballPlayer(){FirstName="Mark",LastName="Canha",Position=BaseballPositionsEnum.LeftFielder},
                new BaseballPlayer(){FirstName="Omar",LastName="Narvaez",Position=BaseballPositionsEnum.Catcher},
            }
        };
        public BaseballTeam AwayTeam { get; set; } = new BaseballTeam() { Name = "New York Yankees", Abbreviation = "NYY", AccentColorHex = "#003366" };


    }
}
