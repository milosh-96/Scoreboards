using Scoreboards.Data.Football;

namespace Scoreboards.Features.Football.Output.Event
{
    public class EventOutputOptions
    {
        public FootballEventsEnum ActiveEvent { get; set; }
        public bool FullScreenMode { get; set; } = false;

        /// <summary>
        /// this should be class that will change animation, for example - from bounce to heartbeat.
        /// </summary>
        /// <remarks>
        /// Multiple CSS classes (separated by a space) are allowed, but use them only
        /// if combined classes will result in different behaviour of the animation, not 
        /// for styling purposes.
        /// </remarks>
        public string AnimationCssClass { get; set; } = "animate__heartBeat";

        public string Message { get; set; } = "";

        public List<string> Data { get; set; } = new List<string>();
    }
}
