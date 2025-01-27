namespace leetcode_problem_solving._169._Majority_Element
{
    public class Solution
    {
        public int MajorityElement(int[] nums)
        {
            if (nums.Length == 0)
            {
                return 0;
            }

            IDictionary<int, int> numsDic = new Dictionary<int, int>();
            int n = nums.Length;
            int majority = nums[0];

            for (int i = 0; i <= n - 1; i++)
            {
                if (numsDic.ContainsKey(nums[i]))
                {
                    numsDic[nums[i]] = numsDic[nums[i]] + 1;
                    if (numsDic[nums[i]] > (n / 2))
                    {
                        majority = nums[i];
                        break;
                    }
                }
                else
                {
                    numsDic.Add(nums[i], 1);
                }
            }

            return majority;
        }
    }
}
