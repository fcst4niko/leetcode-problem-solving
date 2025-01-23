// See https://aka.ms/new-console-template for more information


public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        if (m == 0 && n == 0)
        {
            return;
        }

        for (int i = 0; i < nums2.Length; i++)
        {
            for (int j = 0; j < nums1.Length; j++)
            {
                if (nums1[i] == 0)
                {
                    nums1[i] = nums2[j];
                }

                if ((nums1[i] == nums2[j]) || nums1[i] < nums2[j] && nums1[i + 1] > nums2[j])
                {
                    // Correo todo e inserto el nuevo en nums1[i + 1]
                    nums1 = PaddingLeftArray(nums1, i);
                    nums1[i + 1] = nums2[i];
                }
            }
        }
    }

    private int[] PaddingLeftArray(int[] nums1, int index)
    {
        // new array with a new size
        int[] newArray = new int[nums1.Length + 1];

        for (int i = 0; i < index; i++)
        {
            newArray[i] = nums1[i];
        }

        newArray[index] = 0;

        for (int i = index + 1; i < newArray.Length; i++)
        {
            newArray[i] = nums1[i - 1];
        }

        return newArray;
    }
}