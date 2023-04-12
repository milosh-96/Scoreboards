namespace Scoreboards.Data.Baseball
{
    public class BaseballGame
    {
        public BaseballInning CurrentInning { get; set; } = new BaseballInning();
        public BaseballAtBat CurrentAtBat { get; set; } = new BaseballAtBat();
    }
    
}
