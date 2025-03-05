using System;
using System.Collections.Generic;
using System.Linq;
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
            var h1 = 0;
            var v1 = 0;
            var roundtrips = 0;

            while (h >= 1 && v >= 1)
            {
                int[] currentSide = new int[h];

                // Primer recorrido horizontal
                while (h1 < h)
                {
                    currentSide[h1] = matrix[v1][h1];
                    h1++;
                }

                // Primer recorrido vertical
                while (v1 < v)
                {
                    var aux = matrix[v1][h1 - 1];
                    matrix[v1][h1 - 1] = currentSide[v1];
                    currentSide[v1] = aux;
                    v1++;
                }

                // Segundo recorrido horizontal (retroceso)
                h1--; // eliminamos el último incremento 
                while (h1 >= roundtrips)
                {
                    var aux = matrix[v1 - 1][h1];
                    matrix[v1 - 1][h1] = currentSide[h1];
                    currentSide[h1] = aux;
                    h1--;
                }

                // Segundo recorrido vertical (retroceso)
                v1--; // eliminamos el último incremento 
                while (v1 >= roundtrips)
                {
                    var aux = matrix[v1][h1 + 1];
                    matrix[v1][h1 + 1] = currentSide[v1];
                    currentSide[v1] = aux;
                    v1--;
                }

                //Repetimos el primer recorrido para asignar los valores del último
                for (int i = roundtrips; i < h; i++)
                {
                    matrix[0][i] = currentSide[i];
                }

                roundtrips++;
                h1 = roundtrips;
                v1 = roundtrips;
                h--;
                v--;
            }            
        }
    }
}
