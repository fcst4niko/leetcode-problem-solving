using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._48._Rotate_Image
{
    public class Solution
    {
        public void Rotate(int[][] matrix)
        {
            var h = matrix.Length;
            var v = matrix[0].Length;
            var steps = h - 1;
            int x = 0, y = 0;
            int xCurrent = 0;

            while (steps > 1)
            {
                if (xCurrent == steps)
                {
                    x++;
                    y++;
                    steps--;
                    xCurrent = x;
                }
                else
                {
                    var current = matrix[y][xCurrent];

                    if (xCurrent + steps > steps)
                    {
                        current = ProcessNonBorders(matrix, steps, xCurrent, x, y, current);
                    }
                    else // esquinas
                    {
                        current = ProcessBorders(matrix, steps, xCurrent, y, current);
                    }

                    xCurrent++;
                }
            }
        }

        private static int ProcessBorders(int[][] matrix, int steps, int x, int y, int current)
        {
            // 1 de 4 movimientos
            var aux = matrix[0][steps];
            matrix[0][steps] = current;
            current = aux;

            // 2 de 4 movimientos
            aux = matrix[steps][steps];
            matrix[steps][steps] = current;
            current = aux;

            // 3 de 4 movimientos
            aux = matrix[steps][0];
            matrix[steps][0] = current;
            current = aux;

            // 4 de 4 movimientos
            aux = matrix[0][0];
            matrix[0][0] = current;
            current = aux;

            return current;
        }

        private static int ProcessNonBorders(int[][] matrix, int steps, int xCurrent, int x, int y, int current)
        {
            // 1 de 4 movimientos
            var nextX = steps;
            var nextY = y + (steps - xCurrent);

            var aux = matrix[nextY][nextX];
            matrix[nextY][nextX] = current;
            current = aux;

            // 2 de 4 movimientos
            nextX -= y + (steps - xCurrent);
            nextY = steps;

            aux = matrix[nextY][nextX];
            matrix[nextY][nextX] = current;
            current = aux;

            // 3 de 4 movimientos
            nextX = x;
            nextY = xCurrent;

            aux = matrix[nextY][nextX];
            matrix[nextY][nextX] = current;
            current = aux;

            // 4 de 4 movimientos
            nextX = xCurrent;
            nextY = y;

            aux = matrix[nextY][nextX];
            matrix[nextY][nextX] = current;
            current = aux;

            return current;
        }
    }
}
