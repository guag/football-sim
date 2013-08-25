namespace FootballSim.Models.Ratings
{
    public interface IRatingFactory
    {
        Rating Create(RatingType type, int value);
    }

    public class RatingFactory : IRatingFactory
    {
        #region IRatingFactory Members

        public Rating Create(RatingType type, int value)
        {
            return new Rating(type, value);
        }

        #endregion
    }
}