using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using XE_Programming_Exercise.Model;

namespace XE_Programming_Exercise
{
    public static class GroupByItems
    {
        public static IEnumerable<ScannedProducts> groupby(this string products)
        {
            var output = products.ToUpper().ToCharArray()
                .GroupBy(product => product)
                .Select(group => Regex.IsMatch(group.Key.ToString(), @"[A-Z]", RegexOptions.IgnorePatternWhitespace) &&
                Enum.TryParse(group.Key.ToString(), true, out Item item) ? new ScannedProducts(item, group.Count()) : null);

            return output;
        }
    }
}
