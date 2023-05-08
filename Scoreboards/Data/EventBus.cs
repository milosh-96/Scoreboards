namespace Scoreboards.Data
{
    public abstract class EventBus
    {
        private bool isActive = false;

        public bool IsActive
        {
            get { return isActive; }
            set
            {
                isActive = value;

                if (value == true)
                {
                    Task.Delay(TimeSpan.FromSeconds(15))
                        .ContinueWith(t => { isActive = false; });
                }
            }
        }
        public object EventType { get; set; } = new {};

        public ScoreboardEventOutputOptions Options { get; set; } = new ScoreboardEventOutputOptions();

        public string Message { get; set; } = "test";
    }
}
