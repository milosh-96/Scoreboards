using Scoreboards.Data.Football;

namespace Scoreboards.Data
{
    public class FootballEventBus : EventBus
    {
        public FootballEventsEnum EventType { get; set; } = FootballEventsEnum.None;
    }
}
