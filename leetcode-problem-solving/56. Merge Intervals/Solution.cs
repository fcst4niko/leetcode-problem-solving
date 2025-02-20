using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._56._Merge_Intervals
{
    public class Solution
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> mergedIntervals = new List<int[]>();

            if (intervals.Length < 0) return intervals;

            intervals = intervals.OrderBy(x => x[0]).ToArray();

            int i = 0;
            int lastLow = intervals[0][0];
            int lastHigh = intervals[i][intervals[i].Length - 1];
            var lowest = lastLow;
            var highest = lastHigh;
            while (i < intervals.Length)
            {
                var currentLow = intervals[i][0];
                var currentHigh = intervals[i][intervals[i].Length - 1];

                if (currentLow < lowest && currentHigh < lowest )
                {
                    CloseRange(mergedIntervals, ref lowest, ref highest, currentLow, currentHigh);
                }
                if (currentLow > highest)
                {
                    CloseRange(mergedIntervals, ref lowest, ref highest, currentLow, currentHigh);
                }
                else
                {
                    lowest = Math.Min(currentLow, lowest);
                    highest = Math.Max(currentHigh, highest);
                }

                lastLow = currentLow;
                lastHigh = currentHigh;

                i++;
            }

            CloseRange(mergedIntervals, ref lowest, ref highest, lastLow, lastHigh);

            return mergedIntervals.ToArray();
        }

        private static void CloseRange(List<int[]> mergedIntervals, ref int lowest, ref int highest, int currentLow, int currentHigh)
        {
            mergedIntervals.Add([lowest, highest]);
            lowest = currentLow;
            highest = currentHigh;
        }
    }
}
