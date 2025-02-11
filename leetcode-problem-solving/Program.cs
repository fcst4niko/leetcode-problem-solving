// See https://aka.ms/new-console-template for more information

using leetcode_problem_solving._36._Valid_Sudoku;
using System.Diagnostics;

Solution Solution = new Solution();

//char[][] board = new char[][]
//{
//    new char[] { '5', '3', '.', '.', '7', '.', '.', '.', '.' },
//    new char[] { '6', '.', '.', '1', '9', '5', '.', '.', '.' },
//    new char[] { '.', '9', '8', '.', '.', '.', '.', '6', '.' },
//    new char[] { '8', '.', '.', '.', '6', '.', '.', '.', '3' },
//    new char[] { '4', '.', '.', '8', '.', '3', '.', '.', '1' },
//    new char[] { '7', '.', '.', '.', '2', '.', '.', '.', '6' },
//    new char[] { '.', '6', '.', '.', '.', '.', '2', '8', '.' },
//    new char[] { '.', '.', '.', '4', '1', '9', '.', '.', '5' },
//    new char[] { '.', '.', '.', '.', '8', '.', '.', '7', '9' }
//};


char[][] board = new char[][]
{
    new char[] { '.', '.', '.', '.', '5', '.', '.', '1', '.' },
    new char[] { '.', '4', '.', '3', '.', '.', '.', '.', '.' },
    new char[] { '.', '.', '.', '.', '.', '3', '.', '.', '1' },
    new char[] { '8', '.', '.', '.', '.', '.', '.', '2', '.' },
    new char[] { '.', '.', '2', '.', '7', '.', '.', '.', '.' },
    new char[] { '.', '1', '5', '.', '.', '.', '.', '.', '.' },
    new char[] { '.', '.', '.', '.', '.', '2', '.', '.', '.' },
    new char[] { '.', '2', '.', '9', '.', '.', '.', '.', '.' },
    new char[] { '.', '.', '4', '.', '.', '.', '.', '.', '.' }
};




Console.WriteLine(Solution.IsValidSudoku(board));

Console.ReadLine();
