namespace FootballSim.Models.Ratings
{
    public interface IRatingFactory
    {
        Rating Create(int value);
    }

    public class RatingFactory : IRatingFactory
    {
        #region IRatingFactory Members

        public Rating Create(int value)
        {
            return new Rating(value);
        }

        #endregion
    }
}