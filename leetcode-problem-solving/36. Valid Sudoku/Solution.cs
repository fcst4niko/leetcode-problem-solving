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

            List<char[][]> listOfBoards = Split3x3Boards(board);

            foreach (var b in listOfBoards)
            {
                l = b.Length;
                if (!CheckBoard(b, l)) return false;
            }

            return true;
        }

        private static List<char[][]> Split3x3Boards(char[][] board)
        {
            var listOfBoards = new List<char[][]>();

            int x = 0, y = 1, z = 2;

            char[][] board3x3 = new char[][]
            {
                new char[] { board[x][0], board[x][1], board[x][2] },
                new char[] { board[y][0], board[y][1], board[y][2] },
                new char[] { board[z][0], board[z][1], board[z][2] }
            };



            listOfBoards.Add(board3x3);

            x = 0;
            y = 1;
            z = 2;

            board3x3 = new char[ ][]
             {
                new char[] { board[x][3], board[x][4], board[x][5] },
                new char[] { board[y][3], board[y][4], board[y][5] },
                new char[] { board[z][3], board[z][4], board[z][5] }
            };

            listOfBoards.Add(board3x3);

            x = 0;
            y = 1;
            z = 2;

            board3x3 = new char[][]
            {
                new char[] { board[x][6], board[x][7], board[x][8] },
                new char[] { board[y][6], board[y][7], board[y][8] },
                new char[] { board[z][6], board[z][7], board[z][8] }
            };

            listOfBoards.Add(board3x3);

            x = 3;
            y = 4;
            z = 5;

            board3x3 = new char[][]
            {
                new char[] { board[x][0], board[x][1], board[x][2] },
                new char[] { board[y][0], board[y][1], board[y][2] },
                new char[] { board[z][0], board[z][1], board[z][2] }
            };

            listOfBoards.Add(board3x3);

            x = 3;
            y = 4;
            z = 5;

            board3x3 = new char[][]
            {
                new char[] { board[x][3], board[x][4], board[x][5] },
                new char[] { board[y][3], board[y][4], board[y][5] },
                new char[] { board[z][3], board[z][4], board[z][5] }
            };

            listOfBoards.Add(board3x3);

            x = 3;
            y = 4;
            z = 5;

            board3x3 = new char[][]
            {
                new char[] { board[x][6], board[x][7], board[x][8] },
                new char[] { board[y][6], board[y][7], board[y][8] },
                new char[] { board[z][6], board[z][7], board[z][8] }
            };

            listOfBoards.Add(board3x3);

            x = 6;
            y = 7;
            z = 8;

            board3x3 = new char[][]
            {
                new char[] { board[x][0], board[x][1], board[x][2] },
                new char[] { board[y][0], board[y][1], board[y][2] },
                new char[] { board[z][0], board[z][1], board[z][2] }
            };

            listOfBoards.Add(board3x3);

            x = 6;
            y = 7;
            z = 8;

            board3x3 = new char[][]
            {
                new char[] { board[x][3], board[x][4], board[x][5] },
                new char[] { board[y][3], board[y][4], board[y][5] },
                new char[] { board[z][3], board[z][4], board[z][5] }
            };

            listOfBoards.Add(board3x3);

            x = 6;
            y = 7;
            z = 8;

            board3x3 = new char[][]
            {
                new char[] { board[x][6], board[x][7], board[x][8] },
                new char[] { board[y][6], board[y][7], board[y][8] },
                new char[] { board[z][6], board[z][7], board[z][8] }
            };

            listOfBoards.Add(board3x3);
            return listOfBoards;
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
