namespace Scoreboards.Data.Football
{
    public abstract class FootballPlayerEvent
    {
        public FootballPlayer Player { get; set; } = new FootballPlayer();

        // this is represented in seconds //
        public int Time { get; set; } = 0;
    }
}
