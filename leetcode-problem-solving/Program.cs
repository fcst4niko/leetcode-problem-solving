// See https://aka.ms/new-console-template for more information


using leetcode_problem_solving._80._Remove_Duplicates_from_Sorted_Array_II;

Solution solution = new Solution();

//int[] nums = { 1, 1, 1, 2, 2, 3};
int[] nums = { 0, 0, 1, 1, 1, 1, 2, 3, 3 };

int k = solution.RemoveDuplicates(nums);

foreach (var item in nums)
{
    Console.Write($"{item},");
}

Console.ReadLine();

