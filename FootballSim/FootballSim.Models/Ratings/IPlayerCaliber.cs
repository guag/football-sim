namespace FootballSim.Models.Ratings
{
    public interface IPlayerCaliber
    {
        int MinValue { get; }
        int MaxValue { get; }
        string ToString();
    }
}