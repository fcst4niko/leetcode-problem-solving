using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._238._Product_of_Array_Except_Self
{
    public class Solution
    {
        public int[] ProductExceptSelf(int[] nums)
        {
            var i = 0;
            int leftProduct = 1;
            int rightProduct = 1;
            int zeroCount = 0;
            while (i < nums.Length)
            {
                int val;
                if (nums[i] == 0)
                {
                    val = 1;
                    zeroCount++;
                }
                else
                {
                    val = nums[i];
                }

                rightProduct *= val;
                i++;
            }

            for (i = 0; i < nums.Length; i++)
            {
                if (zeroCount > 1)
                {
                    nums[i] = 0;
                }
                else if (zeroCount == 1)
                {
                    if (nums[i] == 0)
                    {
                        nums[i] = leftProduct * (rightProduct / 1);
                        leftProduct *= nums[i];
                    }
                    else
                    {
                        nums[i] = 0;
                    }
                }
                else
                {
                    nums[i] = leftProduct * (rightProduct / nums[i]);
                    //leftProduct *= nums[i];
                }
            }

            return nums;
        }
    }
}
