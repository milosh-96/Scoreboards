namespace Scoreboards.Data.Baseball
{
    public enum BaseballPositionsEnum
    {
        DesignatedHitter,
        Pitcher,
        Catcher,
        FirstBaseman,
        SecondBaseman,
        ThirdBaseman,
        Shortstop,
        LeftFielder,
        CenterFielder,
        RightFielder

    }

    public static class BaseballPositionsEnumHandler {

        public static string DisplayName(BaseballPositionsEnum position)
        {
            string displayName = "";
            switch(position)
            {
                case BaseballPositionsEnum.DesignatedHitter:
                    displayName="Designated Hitter";
                    break; 
                case BaseballPositionsEnum.Pitcher:
                    displayName="Pitcher";
                    break;
                case BaseballPositionsEnum.Catcher:
                    displayName="Catcher";
                    break;
                case BaseballPositionsEnum.FirstBaseman:
                    displayName="First Baseman";
                    break;
                case BaseballPositionsEnum.SecondBaseman:
                    displayName="Second Baseman";
                    break;
                case BaseballPositionsEnum.ThirdBaseman:
                    displayName="Third Baseman";
                    break;
                case BaseballPositionsEnum.Shortstop:
                    displayName="Shortstop";
                    break;
                case BaseballPositionsEnum.LeftFielder:
                    displayName="Left Fielder";
                    break;
                case BaseballPositionsEnum.CenterFielder:
                    displayName="Center Fielder";
                    break;
                case BaseballPositionsEnum.RightFielder:
                    displayName="Right Fielder";
                    break;
            }
            return displayName;
        } 
        public static string DisplayTwoLetterAbbreviation(BaseballPositionsEnum position)
        {
            string displayName = "";
            switch(position)
            {
                case BaseballPositionsEnum.DesignatedHitter:
                    displayName="DH";
                    break; 
                case BaseballPositionsEnum.Pitcher:
                    displayName="P";
                    break;
                case BaseballPositionsEnum.Catcher:
                    displayName="C";
                    break;
                case BaseballPositionsEnum.FirstBaseman:
                    displayName="1B";
                    break;
                case BaseballPositionsEnum.SecondBaseman:
                    displayName="2B";
                    break;
                case BaseballPositionsEnum.ThirdBaseman:
                    displayName="3B";
                    break;
                case BaseballPositionsEnum.Shortstop:
                    displayName="SS";
                    break;
                case BaseballPositionsEnum.LeftFielder:
                    displayName="LF";
                    break;
                case BaseballPositionsEnum.CenterFielder:
                    displayName="CF";
                    break;
                case BaseballPositionsEnum.RightFielder:
                    displayName="RF";
                    break;
            }
            return displayName;
        }
    }
}
