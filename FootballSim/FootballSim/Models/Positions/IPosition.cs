namespace FootballSim.Models.Positions
{
    public interface IPosition
    {
        PositionType Type { get; }
        string Name { get; }
        Side Side { get; }
        int MinWeight { get; }
        int MaxWeight { get; }
        int MinHeight { get; }
        int MaxHeight { get; }
    }

    public enum PositionType
    {
        None,
        Quarterback,
        Halfback,
        WideReceiver,
        TightEnd,
        Tackle,
        Guard,
        Center,
        DefensiveEnd,
        DefensiveTackle,
        OutsideLinebacker,
        InsideLinebacker,
        Cornerback,
        FreeSafety,
        StrongSafety,
        Kicker,
        Punter
    }

    public enum Side
    {
        None, Offense, Defense, SpecialTeams
    }
}