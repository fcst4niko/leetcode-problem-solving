using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._11._Container_With_Most_Water
{
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            var pointer1 = 0;
            var pointer2 = height.Length - 1;
            var result = 0;

            while (pointer1 < pointer2)
            {
                var currentDistance = pointer2 - pointer1;
                var lowest = int.Min(height[pointer1], height[pointer2]);
                result = int.Max(result, currentDistance * lowest);

                if (height[pointer1] < height[pointer2])
                {
                    pointer1++;
                }
                else
                {
                    pointer2--;
                }
            }

            return result;
        }
    }
}
