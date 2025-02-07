using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._274._H_Index
{
    public class Solution
    {
        public int HIndex(int[] citations)
        {
            if (citations.Length < 1) return 0;

            Array.Sort(citations);

            var hindex = 0;
            for (int h = citations.Length - 1; h >= 0; h--)
            {
                if (hindex >= citations[h])
                {
                    break;
                }
                hindex++;
            }

            return hindex;
        }
    }
}
