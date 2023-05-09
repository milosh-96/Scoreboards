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
                   
                }
            }
        }
        public object EventType { get; set; } = new {};

        public ScoreboardEventOutputOptions Options { get; set; } = new ScoreboardEventOutputOptions();

        public string Message { get; set; } = "test";

        public List<KeyValuePair<string, string>> Data { get; set; } = new List<KeyValuePair<string, string>>();
    
        public  void Activate(TimeSpan? duration = null)
        {
            this.IsActive = true;
            Task.Delay(duration ?? TimeSpan.FromSeconds(15))
                      .ContinueWith(t => {
                          this.IsActive = false;
                          this.Message = "";
                          this.Data = new List<KeyValuePair<string, string>>();
                          this.Options = new ScoreboardEventOutputOptions();
                      });
        }
    
    }
}
