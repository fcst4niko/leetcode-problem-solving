using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._125._Valid_Palindrome
{
    public class Solution
    {
        public bool IsPalindrome(string s)
        {
            s = s.ToLower().Trim();
            if (string.IsNullOrEmpty(s)) return true;

            Queue<char> forward = new Queue<char>();
            Stack<char> backward = new Stack<char>();

            foreach (char c in s.ToCharArray())
            {
                if (((int)c >= 97 && (int)c <= 122) 
                    || ((int)c >= 48 && (int)c <= 57))
                {
                    forward.Enqueue(c);
                    backward.Push(c);
                }
            }

            int count = 1;
            int limit = forward.Count;
            while (limit >= count++)
            {
                int forwardChar = (int)forward.Dequeue();
                int backwardChar = (int)backward.Pop();

                if (forwardChar != backwardChar) return false;
            }

            return true;

        }
    }
}
