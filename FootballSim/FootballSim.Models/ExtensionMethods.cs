using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballSim.Models
{
    public static class ExtensionMethods
    {
        /// <summary>
        /// Orders the given enumerable either in ascending or
        /// descending order, depending on which order is provided.
        /// </summary>
        /// <returns>
        /// The source collection in descending order if order param
        /// is "DESC", otherwise in ascending order.
        /// </returns>
        public static IOrderedEnumerable<TSource> OrderBy<TSource, TKey>(
            this IEnumerable<TSource> source, Func<TSource, TKey> keySelector,
            string order)
        {
            return order.Equals("DESC")
                       ? source.OrderByDescending(keySelector)
                       : source.OrderBy(keySelector);
        }
    }
}