using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._56._Merge_Intervals
{
    public class Solution2
    {
        public int[][] Merge(int[][] intervals)
        {
            List<int[]> mergedIntervals = new List<int[]>();

            if (intervals.Length < 0) return intervals;

            int i = 0;
            int lowest = intervals[0][0];
            int lastHigh = intervals[0][intervals[0].Length - 1];
            int highest = intervals[0][intervals[0].Length - 1];
            while (i < intervals.Length)
            {
                var currentLow = intervals[i][0];

                if (currentLow < lowest) { lowest = currentLow; }

                if (currentLow > lastHigh)
                {
                    CloseRange(mergedIntervals, ref lowest, ref highest, currentLow);
                }

                lastHigh = intervals[i][intervals[i].Length - 1];

                if (highest < lastHigh) { highest = lastHigh; }

                if (currentLow < lowest && lastHigh < lowest) CloseRange(mergedIntervals, ref lowest, ref highest, currentLow);
                i++;
            }

            mergedIntervals.Add([lowest, highest > 0 ? highest : lastHigh]);

            return mergedIntervals.ToArray();
        }

        private static void CloseRange(List<int[]> mergedIntervals, ref int lowest, ref int highest, int currentLow)
        {
            mergedIntervals.Add([lowest, highest]);
            lowest = currentLow;
            highest = 0;
        }
    }
}
