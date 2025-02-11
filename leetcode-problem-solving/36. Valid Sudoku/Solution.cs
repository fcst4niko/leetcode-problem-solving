using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._36._Valid_Sudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            int l = board.Length;

            if (!CheckBoard(board, l)) return false;

            if (!Validate3x3Boards(board)) return false;

            return true;
        }

        private static bool Validate3x3Boards(char[][] board)
        {

            int x = 0, y = 1, z = 2;

            HashSet<char> boardSet = new HashSet<char>();
            if (board[x][0] != '.' && !boardSet.Add(board[x][0])) return false;
            if (board[y][0] != '.' && !boardSet.Add(board[y][0])) return false;
            if (board[z][0] != '.' && !boardSet.Add(board[z][0])) return false;
            if (board[x][1] != '.' && !boardSet.Add(board[x][1])) return false;
            if (board[y][1] != '.' && !boardSet.Add(board[y][1])) return false;
            if (board[z][1] != '.' && !boardSet.Add(board[z][1])) return false;
            if (board[x][2] != '.' && !boardSet.Add(board[x][2])) return false;
            if (board[y][2] != '.' && !boardSet.Add(board[y][2])) return false;
            if (board[z][2] != '.' && !boardSet.Add(board[z][2])) return false;
            boardSet.Clear();

            x = 0;
            y = 1;
            z = 2;

            boardSet = new HashSet<char>();
            if (board[x][3] != '.' && !boardSet.Add(board[x][3])) return false;
            if (board[y][3] != '.' && !boardSet.Add(board[y][3])) return false;
            if (board[z][3] != '.' && !boardSet.Add(board[z][3])) return false;
            if (board[x][4] != '.' && !boardSet.Add(board[x][4])) return false;
            if (board[y][4] != '.' && !boardSet.Add(board[y][4])) return false;
            if (board[z][4] != '.' && !boardSet.Add(board[z][4])) return false;
            if (board[x][5] != '.' && !boardSet.Add(board[x][5])) return false;
            if (board[y][5] != '.' && !boardSet.Add(board[y][5])) return false;
            if (board[z][5] != '.' && !boardSet.Add(board[z][5])) return false;
            boardSet.Clear();

            x = 0;
            y = 1;
            z = 2;

            boardSet = new HashSet<char>();
            if (board[x][6] != '.' && !boardSet.Add(board[x][6])) return false;
            if (board[y][6] != '.' && !boardSet.Add(board[y][6])) return false;
            if (board[z][6] != '.' && !boardSet.Add(board[z][6])) return false;
            if (board[x][7] != '.' && !boardSet.Add(board[x][7])) return false;
            if (board[y][7] != '.' && !boardSet.Add(board[y][7])) return false;
            if (board[z][7] != '.' && !boardSet.Add(board[z][7])) return false;
            if (board[x][8] != '.' && !boardSet.Add(board[x][8])) return false;
            if (board[y][8] != '.' && !boardSet.Add(board[y][8])) return false;
            if (board[z][8] != '.' && !boardSet.Add(board[z][8])) return false;
            boardSet.Clear();

            x = 3;
            y = 4;
            z = 5;

            boardSet = new HashSet<char>();
            if (board[x][0] != '.' && !boardSet.Add(board[x][0])) return false;
            if (board[y][0] != '.' && !boardSet.Add(board[y][0])) return false;
            if (board[z][0] != '.' && !boardSet.Add(board[z][0])) return false;
            if (board[x][1] != '.' && !boardSet.Add(board[x][1])) return false;
            if (board[y][1] != '.' && !boardSet.Add(board[y][1])) return false;
            if (board[z][1] != '.' && !boardSet.Add(board[z][1])) return false;
            if (board[x][2] != '.' && !boardSet.Add(board[x][2])) return false;
            if (board[y][2] != '.' && !boardSet.Add(board[y][2])) return false;
            if (board[z][2] != '.' && !boardSet.Add(board[z][2])) return false;
            boardSet.Clear();

            x = 3;
            y = 4;
            z = 5;

            boardSet = new HashSet<char>();
            if (board[x][3] != '.' && !boardSet.Add(board[x][3])) return false;
            if (board[y][3] != '.' && !boardSet.Add(board[y][3])) return false;
            if (board[z][3] != '.' && !boardSet.Add(board[z][3])) return false;
            if (board[x][4] != '.' && !boardSet.Add(board[x][4])) return false;
            if (board[y][4] != '.' && !boardSet.Add(board[y][4])) return false;
            if (board[z][4] != '.' && !boardSet.Add(board[z][4])) return false;
            if (board[x][5] != '.' && !boardSet.Add(board[x][5])) return false;
            if (board[y][5] != '.' && !boardSet.Add(board[y][5])) return false;
            if (board[z][5] != '.' && !boardSet.Add(board[z][5])) return false;
            boardSet.Clear();

            x = 3;
            y = 4;
            z = 5;


            boardSet = new HashSet<char>();
            if (board[x][6] != '.' && !boardSet.Add(board[x][6])) return false;
            if (board[y][6] != '.' && !boardSet.Add(board[y][6])) return false;
            if (board[z][6] != '.' && !boardSet.Add(board[z][6])) return false;
            if (board[x][7] != '.' && !boardSet.Add(board[x][7])) return false;
            if (board[y][7] != '.' && !boardSet.Add(board[y][7])) return false;
            if (board[z][7] != '.' && !boardSet.Add(board[z][7])) return false;
            if (board[x][8] != '.' && !boardSet.Add(board[x][8])) return false;
            if (board[y][8] != '.' && !boardSet.Add(board[y][8])) return false;
            if (board[z][8] != '.' && !boardSet.Add(board[z][8])) return false;
            boardSet.Clear();

            x = 6;
            y = 7;
            z = 8;

            boardSet = new HashSet<char>();
            if (board[x][0] != '.' && !boardSet.Add(board[x][0])) return false;
            if (board[y][0] != '.' && !boardSet.Add(board[y][0])) return false;
            if (board[z][0] != '.' && !boardSet.Add(board[z][0])) return false;
            if (board[x][1] != '.' && !boardSet.Add(board[x][1])) return false;
            if (board[y][1] != '.' && !boardSet.Add(board[y][1])) return false;
            if (board[z][1] != '.' && !boardSet.Add(board[z][1])) return false;
            if (board[x][2] != '.' && !boardSet.Add(board[x][2])) return false;
            if (board[y][2] != '.' && !boardSet.Add(board[y][2])) return false;
            if (board[z][2] != '.' && !boardSet.Add(board[z][2])) return false;
            boardSet.Clear();

            x = 6;
            y = 7;
            z = 8;

            boardSet = new HashSet<char>();
            if (board[x][3] != '.' && !boardSet.Add(board[x][3])) return false;
            if (board[y][3] != '.' && !boardSet.Add(board[y][3])) return false;
            if (board[z][3] != '.' && !boardSet.Add(board[z][3])) return false;
            if (board[x][4] != '.' && !boardSet.Add(board[x][4])) return false;
            if (board[y][4] != '.' && !boardSet.Add(board[y][4])) return false;
            if (board[z][4] != '.' && !boardSet.Add(board[z][4])) return false;
            if (board[x][5] != '.' && !boardSet.Add(board[x][5])) return false;
            if (board[y][5] != '.' && !boardSet.Add(board[y][5])) return false;
            if (board[z][5] != '.' && !boardSet.Add(board[z][5])) return false;
            boardSet.Clear();

            x = 6;
            y = 7;
            z = 8;

            boardSet = new HashSet<char>();
            if (board[x][6] != '.' && !boardSet.Add(board[x][6])) return false;
            if (board[y][6] != '.' && !boardSet.Add(board[y][6])) return false;
            if (board[z][6] != '.' && !boardSet.Add(board[z][6])) return false;
            if (board[x][7] != '.' && !boardSet.Add(board[x][7])) return false;
            if (board[y][7] != '.' && !boardSet.Add(board[y][7])) return false;
            if (board[z][7] != '.' && !boardSet.Add(board[z][7])) return false;
            if (board[x][8] != '.' && !boardSet.Add(board[x][8])) return false;
            if (board[y][8] != '.' && !boardSet.Add(board[y][8])) return false;
            if (board[z][8] != '.' && !boardSet.Add(board[z][8])) return false;
            boardSet.Clear();

            return true;
        }

        private static bool CheckBoard(char[][] board, int l)
        {
            // revisamos filas
            for (int i = 0; i < l; i++)
            {
                if (!IsValidLine(board[i].Length, j => board[i][j]))
                {
                    return false;
                }
            }

            // revisamos columnas
            for (int i = 0; i < l; i++)
            {
                if (!IsValidLine(l, j => board[j][i]))
                {
                    return false;
                }
            }

            return true;
        }

        private static bool IsValidLine(int length, Func<int, char> getChar)
        {
            HashSet<int> set = new HashSet<int>();

            for (int j = 0; j < length; j++)
            {
                char c = getChar(j);

                if (!char.IsDigit(c)) continue;

                int digit = c - 48;

                if (set.Contains(digit)) return false;

                set.Add(digit);
            }

            set.Clear();

            return true;
        }
    }
}
