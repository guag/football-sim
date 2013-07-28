using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballSim.Models
{
    public interface IPasserRatingService
    {
        double GetRating(double atts, double comps, double yds, double tds, double ints);
    }

    public class PasserRatingService : IPasserRatingService
    {
        private const Double Max = 2.375;

        /// <summary>
        /// Calculates a passer (QB) rating based on the given inputs.
        /// </summary>
        /// <param name="atts">The number of passing attempts</param>
        /// <param name="comps">The number of passing completions</param>
        /// <param name="yds">The number of passing yards</param>
        /// <param name="tds">The number of passing touchdowns</param>
        /// <param name="ints">The number of interceptions</param>
        /// <returns>The passer rating as a double</returns>
        public double GetRating(double atts, double comps, double yds, double tds, double ints)
        {
            var calcs = new List<double>
            {
                (comps / atts - .3) * 5, // Percentage of completions.
                (yds / atts - 3) / 4, // Average yards gained per attempt.
                (tds / atts) * 20, // Percentage of touchdown passes.
                Max - (((ints / atts) * 100) / 4) // Percentage of interceptions.
            };
            var result = (calcs.Sum(c => GetVal(c)) * 100) / 6;
            return Math.Round(result, 1); // Round to 1 decimal place.
        }

        /// <summary>
        /// Retrieves the given value within a certain range.
        /// </summary>
        /// <param name="val">The value</param>
        /// <returns>0 if val is less than 0, 
        /// Max if val is greater than Max, 
        /// otherwise 'val'.</returns>
        private static double GetVal(double val)
        {
            return (val < 0) ? 0 : Math.Min(val, Max);
        }
    }
}