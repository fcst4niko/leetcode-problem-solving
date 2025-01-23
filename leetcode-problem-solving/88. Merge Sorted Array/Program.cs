// See https://aka.ms/new-console-template for more information


Solution solution = new Solution();

//// example N 1
int[] nums1 = [1, 2, 3, 0, 0, 0];
int[] nums2 = [2, 5, 6];
solution.Merge(nums1, 3, nums2, 3);

//// example N 2
//nums1 = [1];
//nums2 = [];
//solution.Merge(nums1, 1, nums2, 0);

//// example N 3
//nums1 = [0];
//nums2 = [1];
//solution.Merge(nums1, 0, nums2, 1);

// //example 4
//nums1 = [2, 0];
//nums2 = [1];
//solution.Merge(nums1, 1, nums2, 1);

////example 5
//nums1 = [4, 5, 6, 0, 0, 0];
//nums2 = [1, 2, 3];
//solution.Merge(nums1, 1, nums2, 1);

////example 6
nums1 = [-1, 0, 0, 3, 3, 3, 0, 0, 0];
nums2 = [1, 2, 2];
solution.Merge(nums1, 6, nums2, 3);

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