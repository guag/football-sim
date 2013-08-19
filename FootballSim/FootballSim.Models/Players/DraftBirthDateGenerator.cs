using System;

namespace FootballSim.Models.Players
{
    public interface IDraftBirthDateGenerator
    {
        DateTime Generate(int draftYear);
    }

    public class DraftBirthDateGenerator : IDraftBirthDateGenerator
    {
        private readonly IRandomService _random;

        public DraftBirthDateGenerator(IRandomService random)
        {
            _random = random;
        }

        #region IDraftBirthDateGenerator Members

        public DateTime Generate(int draftYear)
        {
            var year = _random.GetRandom(draftYear - 25, draftYear - 20);
            var month = _random.GetRandom(1, 13);
            var day = _random.GetRandom(1, DateTime.DaysInMonth(year, month) + 1);
            return new DateTime(year, month, day);
        }

        #endregion
    }
}