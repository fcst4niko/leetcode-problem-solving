using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._55._Jump_Game
{
    public class Solution
    {
        public bool CanJump(int[] nums)
        {
            if (nums.Length == 0) return false;
            if (nums[0] == 0 && nums.Length == 1) return true;
            if (nums[0] == 0 && nums.Length > 1) return false;

            for (int i = nums.Length - 2; i >= 0; i--)
            {
                if (nums[i] == 0)
                {
                    int cont = 1;
                    bool result = false;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (nums[j] > cont)
                        {
                            result = true;
                            break;
                        }
                        cont++;
                    }

                    if (result == false) return false;
                }
            }

            return true;
        }
    }
}
