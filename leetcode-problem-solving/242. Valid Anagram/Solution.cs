using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._242._Valid_Anagram
{
    class Solution
    {
        public bool IsAnagram(string s, string t)
        {
            var dictionary = new Dictionary<char, int>();

            if (s.Length != t.Length) { return false; }

            for (int i = 0; i < s.Length; i++)
            {
                if (dictionary.ContainsKey(s[i]))
                {
                    dictionary[s[i]]++;
                }
                else
                {
                    dictionary[s[i]] = 1;
                }
            }
            for (int z = 0; z < t.Length; z++)
            {
                if (dictionary.ContainsKey(t[z]))
                {
                    dictionary[t[z]]--;
                    if (dictionary[t[z]] <= 0)
                    {
                        dictionary.Remove(t[z]);
                    }
                }
            }

            return dictionary.Count == 0;
        }
    }
}
