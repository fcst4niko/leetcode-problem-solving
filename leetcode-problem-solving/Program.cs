﻿// See https://aka.ms/new-console-template for more information


using leetcode_problem_solving._26._Remove_Duplicates_from_Sorted_Array;

Solution solution = new Solution();

int[] nums = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };

int k = solution.RemoveDuplicates(nums);

Console.WriteLine($"k = {k}");

foreach (var item in nums)
{
    Console.Write($"{item},");
}

Console.ReadLine();


