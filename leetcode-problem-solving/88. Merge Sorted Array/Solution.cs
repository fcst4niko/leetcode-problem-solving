using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._88._Merge_Sorted_Array
{
    public class Solution
    {
        public void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            if (m == 0 && n == 0)
            {
                return;
            }

            for (int j = 0; j < nums2.Length; j++)
            {
                for (int i = 0; i < nums1.Length; i++)
                {
                    if (nums1[i] == 0)
                    {
                        nums1[i] = nums2[j];
                        break;
                    }

                    if ((nums1[i] == nums2[j])
                        || (nums1[i] < nums2[j] && nums1[i + 1] > nums2[j]))
                    {
                        nums1 = PaddingLeftArray(nums1, i + 1);
                        nums1[i + 1] = nums2[j];
                        break;
                    }
                    else if (nums2[j] < nums1[i])
                    {
                        nums1 = PaddingLeftArray(nums1, i);
                        nums1[i] = nums2[j];
                        break;
                    }

                }
            }

            Array.Sort(nums1);
        }

        private int[] PaddingLeftArray(int[] nums1, int index)
        {
            for (int i = nums1.Length - 1; i > index; i--)
            {
                nums1[i] = nums1[i - 1];
            }

            return nums1;
        }
    }

    // Solución de CHATGPT o1:  https://chatgpt.com/c/67928e9b-d638-800d-978c-d0e1eb76efa5?model=o1
}
