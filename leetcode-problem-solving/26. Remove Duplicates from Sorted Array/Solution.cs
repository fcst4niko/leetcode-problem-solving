using AlgoHub;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._26._Remove_Duplicates_from_Sorted_Array
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            int last = nums[0];
            int k = 1;

            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[i] == last)
                {
                    // int.MaxValue: flagged to remove
                    nums[i] = int.MaxValue;
                    continue;
                }
                k++;
                last = nums[i];
            }

            QuickSort.Sort(nums, 0, nums.Length - 1);

            return k;
        }
    }
}
