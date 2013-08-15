namespace FootballSim.Models.Ratings
{
    public struct Rating
    {
        public Rating(int rating) : this()
        {
            CurrentValue = rating;
            ProjectedValue = rating;
        }

        public int CurrentValue { get; set; }
        public int ProjectedValue { get; set; }
    }
}