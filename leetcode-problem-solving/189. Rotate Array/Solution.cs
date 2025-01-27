namespace leetcode_problem_solving._189._Rotate_Array
{
    public class Solution
    {
        public void Rotate(int[] nums, int k)
        {
            //int[] numsAux = nums;
            while (nums.Length < k)
            {
                k = k - nums.Length;
            }
            LinkedList<int> ints = new LinkedList<int>();

            for (int i = 0; i <= nums.Length - 1 - k; i++)
            {
                ints.AddLast(nums[i]);
            }
            for (int i = nums.Length - 1; i > nums.Length - 1 - k && i >= 0; i--)
            {
                ints.AddFirst(nums[i]);
            }

            int[] rotatedArray = ints.ToArray();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rotatedArray[i];
            }
        }
    }
}
