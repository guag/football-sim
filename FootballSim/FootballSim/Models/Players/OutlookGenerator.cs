using FootballSim.Models.Draft;

namespace FootballSim.Models.Players
{
    public interface IOutlookGenerator
    {
        Caliber GenerateCaliber();
    }

    public class OutlookGenerator : IOutlookGenerator
    {
        private readonly IRandomService _random;

        public OutlookGenerator(IRandomService random)
        {
            _random = random;
        }

        #region ICaliberGenerator Members

        public Caliber GenerateCaliber()
        {
            int rand = _random.GetRandom(0, 100);
            if (rand < 5)
            {
                return Caliber.BlueChip;
            }
            if (rand < 21)
            {
                return Caliber.High;
            }
            return (rand < 51) ? Caliber.Average : Caliber.Scrub;
        }

        #endregion
    }
}