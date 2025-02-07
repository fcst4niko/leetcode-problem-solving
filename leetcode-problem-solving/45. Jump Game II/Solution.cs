using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._45._Jump_Game_II
{
    public class Solution
    {
        public int Jump(int[] nums)
        {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return 0;
            if (nums[0] == 0 && nums.Length > 1) return 0;
            //if (nums[0] + 1 >= nums.Length) return 1;

            int bestOption = 0;
            int posHighestOption = 1;
            int cont = 1;
            int iAux = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                int jumps = nums[i] + posHighestOption;
                if (jumps >= nums.Length) return cont;

                int currentMaxJumps = nums[i];                

                for (int j = i + 1; j <=  i + currentMaxJumps; j++)
                {
                    if (nums[j] + j >= bestOption)
                    {
                        bestOption = nums[j] + j;
                        posHighestOption = j + 1;
                        iAux = j - 1;
                    }
                }
                i = iAux;
                bestOption = 0;
                cont++;
            }

            return 0;
        }
    }
}
