namespace FootballSim.Models.Positions
{
    public interface IPosition
    {
        PositionType Type { get; }
        string Name { get; }
        Side Side { get; }
        double MinWeight { get; }
        double MaxWeight { get; }
        double MinHeight { get; }
        double MaxHeight { get; }
    }

    public enum PositionType
    {
        None,
        Quarterback,
        Halfback
    }

    public enum Side
    {
        None, Offense, Defense, SpecialTeams
    }
}