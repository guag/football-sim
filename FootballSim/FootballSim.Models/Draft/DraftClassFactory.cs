namespace FootballSim.Models.Draft
{
    public interface IDraftClassFactory
    {
        DraftClass Create(int year);
    }

    public class DraftClassFactory : IDraftClassFactory
    {
        #region IDraftClassFactory Members

        public DraftClass Create(int year)
        {
            return new DraftClass {Year = year};
        }

        #endregion
    }
}