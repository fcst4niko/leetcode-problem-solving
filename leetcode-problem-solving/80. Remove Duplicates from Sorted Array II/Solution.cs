using AlgoHub;

namespace leetcode_problem_solving._80._Remove_Duplicates_from_Sorted_Array_II
{
    public class Solution
    {
        public int RemoveDuplicates(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 1;

            int last = nums[0];
            int k = 1;
            int twice = 1;

            for (int i = 1; i <= nums.Length - 1; i++)
            {
                if (nums[i] == last)
                {
                    twice++;
                    // int.MaxValue: flagged to remove
                    if (twice > 2)
                    {
                        nums[i] = int.MaxValue;                        
                        continue;
                    }
                }
                else
                {
                    twice = 1;
                }
                k++;
                last = nums[i];
            }

            QuickSort.Sort(nums, 0, nums.Length - 1);

            return k;
        }
    }
}
