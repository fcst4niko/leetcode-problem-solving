using AlgoHub;

namespace leetcode_problem_solving._27._Remove_Element
{
    public class Solution
    {
        public int RemoveElement(int[] nums, int val)
        {
            int k = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val)
                {
                    nums[i] = 999;
                    continue;
                }
                k++;
            }

            //Array.Sort(nums);
            QuickSort.Sort(nums, 0, nums.Length - 1);

            return k;
        }
    }
}

// Youtube QuickSort: https://www.youtube.com/watch?v=tIYMCYooo3c&t=54s