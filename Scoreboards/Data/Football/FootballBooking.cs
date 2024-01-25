namespace Scoreboards.Data.Football
{
    public class FootballlBookinig : FootballPlayerEvent
    {
      
        public FootballBookingType BookingType { get; set; }
      
    }

    public enum FootballBookingType {
        YellowCard,
        RedCard,
        DirectRedCard
    }
}
