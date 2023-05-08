namespace Scoreboards.Data
{
    public class ScoreboardEventOutputOptions
    {
        public int FontSize { get; set; } = 10;

        public string BackgroundColor { get; set; } = "#dd0000";
        public string FontColor { get; set; } = "#fff";

        public List<string> AnimationCssClasses { get; set; } = new List<string>()
        {
            "animate__animated","animate__tada","animate__infinite"
        };
    }
}
