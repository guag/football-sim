namespace FootballSim.Models.Ratings
{
    public struct Rating
    {
        public int CurrentValue { get; set; }
        public int ProjectedValue { get; set; }
    }

    public enum RatingType
    {
        Passing,
        Rushing,
        Blocking,
        Catching,
        PassDefense,
        RunDefense,
        Tackling,
        Speed,
        Strength
        // and more...
    }
}
