namespace Scoreboards.Data.Football
{
    public class FootballPlayer : Player
    {
        public override string ToString()
        {
            return String.Format("#{0} {1} {2}", ShirtNumber, FirstName, LastName);
        }
    }
}
