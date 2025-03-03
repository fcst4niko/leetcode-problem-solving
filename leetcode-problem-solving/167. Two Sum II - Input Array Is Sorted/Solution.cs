﻿using System.Net;

namespace leetcode_problem_solving._167._Two_Sum_II___Input_Array_Is_Sorted
{
    public class Solution
    {
        public int[] TwoSum(int[] numbers, int target)
        {
            int start = 0;
            int end = numbers.Length - 1;
            int[] result = new int[] { 1, 2 };

            while ((start < numbers.Length || end >= 0 ) && numbers.Length != 2)
            {
                var startPointer = numbers[start];
                var endPointer = numbers[end];

                if (startPointer + endPointer == target)
                {
                    // salir con resultado
                    result[0] = start + 1;
                    result[1] = end + 1;
                    break;
                }
                else if (startPointer + endPointer != target && start < end)
                {
                    end--;
                }
                else // if (startPointer + endPointer > target)
                {
                    start++;
                    end = numbers.Length - 1;
                }
            }

            return result;
        }
    }
}
