using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._209._Minimum_Size_Subarray_Sum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            if (nums.Contains(target)) return 1;

            int window = 1;

            int sum = 0;

            while (window <= nums.Length)
            {
                for (int i = 0; i < window; i++)
                {
                    sum += nums[i];
                }

                if (sum >= target)
                {
                    return window;
                }
                else
                {
                    for (int i = window; i < nums.Length; i++)
                    {
                        sum += nums[i] - nums[i - window];

                        if (sum >= target)
                        {
                            return window;
                        }
                    }

                    window++;
                    sum = 0;                    
                }
            }

            return 0;
        }
    }
}
