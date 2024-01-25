namespace Scoreboards.Data
{
    public class Clock
    {
        public int Milliseconds { get; set; } = 0;

        public override string ToString()
        {
            var timeSpan = TimeSpan.FromMilliseconds(Milliseconds);
            return string.Format("{0:D2}:{1:D2}",
                (int)timeSpan.TotalMinutes,
                timeSpan.Seconds);
        }
    }


}
