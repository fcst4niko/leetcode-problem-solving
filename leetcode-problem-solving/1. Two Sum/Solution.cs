using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._1._Two_Sum
{
    public class Solution
    {
        public int[] TwoSum(int[] nums, int target)
        {
            IDictionary<int, int[]> dictionary = new Dictionary<int, int[]>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dictionary.ContainsKey(nums[i]))
                {
                    // indice
                    dictionary[nums[i]][0] = i;
                    // Cantidad
                    dictionary[nums[i]][1] += 1;
                }
                else
                {
                    dictionary.Add(nums[i], new int[] { i, 1 });
                }
            }

            var result = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                var xyz = target - nums[i];

                if (dictionary.ContainsKey(xyz))
                {
                    if ((xyz == nums[i] && dictionary[xyz][1] > 1)
                        || (xyz != nums[i]))
                    {
                        result = new int[] { i, dictionary[xyz][0] };
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            return result;
        }
    }
}
