using System.Linq;

namespace leetcode_problem_solving._54._Spiral_Matrix
{
    public class Solution2
    {
        public IList<int> SpiralOrder(int[][] matrix)
        {
            int n = matrix.Length;
            int m = matrix[0].Length;

            var spiral = new List<int>();

            int vertical = 0;
            int horizontal = 0;


            for (int i = 0; i < m - vertical && n - 1 >= vertical ; i++)
            {
                spiral.Add(matrix[vertical][i]);

                if (i == m - vertical - 1)
                {
                    int j = 0;
                    for (j = vertical + 1; j < n - vertical; j++)
                    {
                        spiral.Add(matrix[j][i]);

                    }
                    j--;
                    vertical++;
                    int i2 = 0;
                    for (i2 = m - vertical - 1; i2 >= horizontal; i2--)
                    {
                        spiral.Add(matrix[j][i2]);

                        if (i2 == horizontal)
                        {
                            for (int j2 = n - vertical - 1; j2 >= vertical; j2--)
                            {
                                spiral.Add(matrix[j2][i2]);
                            }

                        }
                    }
                    horizontal++;
                    i = 0;
                }
            }

            return spiral.Take(m * n).ToList();
        }
    }
}
