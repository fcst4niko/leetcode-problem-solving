using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._209._Minimum_Size_Subarray_Sum
{
    public class Solution
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            if (nums.Contains(target)) return 1;

            int window = 0;
            int sum = 0;
            bool isBreaked = false;

            //buscamos primero la máxima ventana que sirve para luego ir reduciendo la ventana...
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                window++;
                if (sum >= target)
                {
                    isBreaked = true;
                    break;
                }
            }

            if (!isBreaked)
            {
                return 0;
            }

            sum = 0;
            var prevWindow = window;
            window--;
            while (window > 0)
            {
                for (int i = 0; i < window; i++)
                {
                    sum += nums[i];
                }

                if (sum < target)
                {
                    for (int i = window; i < nums.Length; i++)
                    {
                        sum += nums[i] - nums[i - window];

                        if (sum >= target)
                        {
                            isBreaked = true;
                            break;
                        }
                    }

                    if (!isBreaked)
                    {
                        return prevWindow;
                    }                    
                }

                isBreaked = false;
                prevWindow = window;
                window--;
                sum = 0;
            }

            return 0;
        }
    }
}
