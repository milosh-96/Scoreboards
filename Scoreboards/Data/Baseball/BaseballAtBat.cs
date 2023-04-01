namespace Scoreboards.Data.Baseball
{
    public class BaseballAtBat
    {
        public BaseballPitcher Pitcher { get; set; } = new BaseballPitcher();
        public BaseballPlayer Batter { get; set; } = new BaseballPlayer();
        public int Strikes { get; set; } = 0;
        public int Balls { get; set; } = 0;
    }
}
