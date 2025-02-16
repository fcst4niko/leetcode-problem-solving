using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._54._Spiral_Matrix
{
    public class Solution
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;
            int take = n * m;
            var spiral = new List<int>();

            int y = 0;
            int auxx = 0;
            int x = 0;
            int lowestLimit = 0;
            while (m >= 1 && n >= 1)
            {
                //First move left to rigth                
                for (x = auxx; x < m; x++)
                {
                    spiral.Add(matrix[y][x]);
                }
                x--;
                int i = y;
                for (i = y + 1; i < n; i++)
                {
                    spiral.Add(matrix[i][x]);
                }
                i--;

                int z = x;
                for (z = x - 1; z >= lowestLimit; z--)
                {
                    spiral.Add(matrix[i][z]);
                }
                z++;


                lowestLimit++;
                int a = i;
                for (a = i - 1; a >= lowestLimit; a--)
                {
                    spiral.Add(matrix[a][z]);
                }

                y++;
                x = ++auxx;
                m--;
                n--;

            }

            return spiral.Take(take).ToList();
        }
    }
}
