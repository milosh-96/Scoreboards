namespace Scoreboards.Areas.App.Pages.Output.Football.Components
{
    public class EventOutputOptions
    {
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
    }
}
