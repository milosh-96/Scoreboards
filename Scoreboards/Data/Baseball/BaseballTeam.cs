using Scoreboards.Data.Football;

namespace Scoreboards.Data.Baseball
{
    public class BaseballTeam : Team
    {
        public BaseballTeam()
        {
            if(Lineup != null && Lineup.Any(x=>x.Position==BaseballPositionsEnum.Pitcher))
            {
                BaseballPlayer? player = Lineup.Where(x => x.Position == BaseballPositionsEnum.Pitcher).FirstOrDefault();
                if(player != null)
                {
                    CurrentPitcher = player.ToPitcher();
                }
            }
        }

        public BaseballTeamStats Stats { get; set; } = new BaseballTeamStats()
        {
            Linescore = Enumerable.Range(1, 12).Select(x => new Halfinning()).ToList()
        };
        public List<BaseballPlayer> Lineup { get; set; } = new List<BaseballPlayer>()
            {
                new BaseballPlayer() {Position=BaseballPositionsEnum.Pitcher},
                new BaseballPlayer() {Position=BaseballPositionsEnum.Catcher},
                new BaseballPlayer() {Position=BaseballPositionsEnum.FirstBaseman},
                new BaseballPlayer() {Position=BaseballPositionsEnum.SecondBaseman},
                new BaseballPlayer() {Position=BaseballPositionsEnum.ThirdBaseman},
                new BaseballPlayer() {Position=BaseballPositionsEnum.Shortstop},
                new BaseballPlayer() {Position=BaseballPositionsEnum.LeftFielder},
                new BaseballPlayer() {Position=BaseballPositionsEnum.CenterFielder},
                new BaseballPlayer() {Position=BaseballPositionsEnum.RightFielder},
               // new BaseballPlayer() {Position=BaseballPositionsEnum.DesignatedHitter}

            };
        public BaseballPitcher CurrentPitcher { get; set; } = new BaseballPitcher();

    }
}
