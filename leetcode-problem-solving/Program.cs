﻿// See https://aka.ms/new-console-template for more information

using leetcode_problem_solving._48._Rotate_Image;

Solution solution = new Solution();


int[][] matrix = [[1, 2, 3], [4, 5, 6], [7, 8, 9]];


solution.Rotate(matrix);

for (int i = 0; i < matrix.Length; i++)
{
	for (int j = 0; j < matrix[0].Length; j++)
	{
		Console.WriteLine(matrix[j][i]);
	}
}

Console.ReadLine();
