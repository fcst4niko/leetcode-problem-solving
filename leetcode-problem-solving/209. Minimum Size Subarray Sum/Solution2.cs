using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._209._Minimum_Size_Subarray_Sum
{
    public class Solution2
    {
        public int MinSubArrayLen2(int target, int[] nums)
        {
            //QuickSort.Sort(nums, 0, nums.Length - 1);
            var cont = 1;
            var previous = 0;

            for (int i = nums.Length - 1; i >= 0; i--)
            {
                cont++;
                if (nums[i] + previous >= target)
                {
                    return cont;
                }
                previous += nums[i];                
            }

            return 0;
        }
    }

    public class QuickSort
    {
        public static void Sort(int[] arr, int low, int high)
        {
            if (low < high)
            {
                // Encuentra la posición del pivote
                int pi = Partition(arr, low, high);

                // Ordenar los elementos a la izquierda del pivote
                Sort(arr, low, pi - 1);

                // Ordenar los elementos a la derecha del pivote
                Sort(arr, pi + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            // Seleccionar el último elemento como pivote
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j < high; j++)
            {
                // Si el elemento actual es menor o igual al pivote
                if (arr[j] <= pivot)
                {
                    i++;
                    // Intercambiar arr[i] y arr[j]
                    Swap(arr, i, j);
                }
            }

            // Intercambiar el pivote al lugar correcto
            Swap(arr, i + 1, high);

            return i + 1;
        }

        static void Swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

    }
}
