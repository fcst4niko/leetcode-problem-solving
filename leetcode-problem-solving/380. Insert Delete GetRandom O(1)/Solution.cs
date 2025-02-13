using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._380._Insert_Delete_GetRandom_O_1_
{
    public class RandomizedSet
    {
        private readonly HashSet<int> set;

        public RandomizedSet()
        {
            set = new HashSet<int>();
        }

        public bool Insert(int val)
        {
            return set.Add(val);
        }

        public bool Remove(int val)
        {
            return set.Remove(val);
        }

        public int GetRandom()
        {
            if (!set.Any()) return 0;

            var values = set.ToArray();
            
            Random random = new Random();

            // Generamos un índice aleatorio entre 0 y el número de elementos - 1
            int indiceAleatorio = random.Next(values.Count());

            // Obtenemos el número aleatorio de la colección
            return values[indiceAleatorio];
        }
    }
}
