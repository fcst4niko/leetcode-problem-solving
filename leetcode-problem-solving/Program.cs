﻿
//// See https://aka.ms/new-console-template for more information

using leetcode_problem_solving._209._Minimum_Size_Subarray_Sum;

Solution solution = new Solution();


////int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];
////int[][] matrix = [[5, 1, 9, 11], [2, 4, 8, 10], [13, 3, 6, 7], [15, 14, 12, 16]];
////int[][] matrix = [[1, 2], [3, 4]];
//int[][] matrix = [[1, 2, 3, 4, 5], [6, 7, 8, 9, 10], [11, 12, 13, 14, 15], [16, 17, 18, 19, 20], [21, 22, 23, 24, 25]];

///*
// * [1, 2, 3] -> [7, 4, 1]
// * [4, 5, 6] -> [8, 5, 2]
// * [7, 8, 9] -> [9, 6, 3]
// */

///*
// * [05, 01, 09, 11] -> [15, 13, 02, 05]
// * [02, 04, 08, 10] -> [14, 03, 04, 01]
// * [13, 03, 06, 07] -> [12, 06, 08, 09]
// * [15, 14, 12, 16] -> [16, 07, 10, 11]
// */

///*
// * [1, 2] -> [3, 1]
// * [3, 4] -> [4, 2]
// */

///*
// * [10, 02, 03, 04, 05] -> [21, 16, 11, 06, 01]
// * [06, 07, 08, 09, 10] -> [22, 17, 12, 07, 02]
// * [11, 12, 13, 14, 15] -> [23, 18, 13, 08, 03]
// * [16, 17, 18, 19, 20] -> [24, 19, 14, 09, 04]
// * [21, 22, 23, 24, 25] -> [25, 20, 15, 10, 05]
// */


//solution.Rotate(matrix);

//for (int i = 0; i < matrix.Length; i++)
//{
//	for (int j = 0; j < matrix[0].Length; j++)
//	{
//		Console.WriteLine(matrix[j][i]);
//	}
//}

//Console.ReadLine();


//int[] num = new int[] { 2, 3, 1, 2, 4, 3 };
int[] num = new int[] { 12, 28, 83, 4, 25, 26, 25, 2, 25, 25, 25, 12};
int target = 213;

Console.WriteLine(solution.MinSubArrayLen(target, num));

Console.ReadLine();


