namespace FootballSim.Models.Draft
{
    public interface IDraftClassFactory
    {
        IDraftClass Create(int year);
    }

    public class DraftClassFactory : IDraftClassFactory
    {
        #region IDraftClassFactory Members

        public IDraftClass Create(int year)
        {
            return new DraftClass {Year = year};
        }

        #endregion
    }
}