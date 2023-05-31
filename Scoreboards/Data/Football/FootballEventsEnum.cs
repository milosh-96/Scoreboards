namespace Scoreboards.Data.Football
{
    public enum FootballEventsEnum
    {
        None = 0,
        MatchStarted = 10,
        HalfTime = 11,
        SecondHalf =12,
        MatchEnd = 13,
        Interruption = 14,
        ExtraTime = 15,
        ExtraTimeFirstHalf = 16,
        ExtraTimeSecondHalf = 17,
        Penalties = 18,
        GoalScored = 20,
        GoalScoredHomeTeam = 21,
        GoalScoredAwayTeam = 22,
        Substitution = 30,
        SubstitutionHomeTeam = 31,
        SubstitutionAwayTeam = 32,
        AdditionalTime = 40,
        AdditionalTimeFirstHalf = 41,
        AdditionalTimeSecondHalf = 42,
        AdditionalTimeExtraTimeFirstHalf = 43,
        AdditionalTimeExtraTimeSecondHalf = 44,
        BookingIssued = 60,
        YellowCardIssued = 61,
        RedCardIssued =62,
        BookingIssuedHomeTeam = 63,
        YellowCardIssuedHomeTeam = 64,
        RedCardIssuedHomeTeam =65,
        BookingIssuedAwayTeam = 66,
        YellowCardIssuedAwayTeam = 67,
        RedCardIssuedAwayTeam =68,

        
    }

    public enum FootballEventsDataKeysEnum
    {
        None = 999,
        GoalScored_Scorer = 21,
        GoalScored_Assist = 22,
        GoalScored_ScoringMinute = 23,
        Substitution_SubbedOutPlayer = 31,
        Substitution_SubbedInPlayer = 32,
    }
}
