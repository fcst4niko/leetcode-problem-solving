using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._155._Min_Stack
{
    public class MinStack
    {

        IList<int> pila;
        int minimum = 0;

        public MinStack()
        {
            pila = new List<int>();
        }

        public void Push(int val)
        {
            pila.Add(val);
        }

        public void Pop()
        {
            pila.RemoveAt(pila.Count - 1);
        }

        public int Top()
        {
            return pila.Last();
        }

        public int GetMin()
        {
            return pila.Min();
        }
    }

    /**
     * Your MinStack object will be instantiated and called as such:
     * MinStack obj = new MinStack();
     * obj.Push(val);
     * obj.Pop();
     * int param_3 = obj.Top();
     * int param_4 = obj.GetMin();
     */
}
