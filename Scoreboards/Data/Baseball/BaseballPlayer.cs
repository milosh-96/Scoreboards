namespace Scoreboards.Data.Baseball
{
    public class BaseballPlayer : Player
    {
        public BaseballPositionsEnum Position { get; set; } = BaseballPositionsEnum.Pitcher;
        
        public BaseballPitcher ToPitcher()
        {
            if (Position == BaseballPositionsEnum.Pitcher)
            {
                return new BaseballPitcher()
                {
                    ShirtNumber = ShirtNumber,
                    FirstName = FirstName,
                    LastName = LastName,
                    Position = BaseballPositionsEnum.Pitcher,
                };
            }
            throw new Exception("Player has to be assigned to the pitcher position.");
        }
    }
}
