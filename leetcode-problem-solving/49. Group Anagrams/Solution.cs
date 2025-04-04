﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetcode_problem_solving._49._Group_Anagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IDictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            foreach (var item in strs)
            {
                var found = false;
                foreach (var value in dictionary.Keys)
                {
                    if (IsAnagram(item, value))
                    {
                        dictionary[value].Add(item);
                        found = true;
                    }
                }

                if (found == false)
                {
                    dictionary.Add(item, new List<string> { item });
                }
            }

            IList<IList<string>> result = new List<IList<string>>();            

            foreach (var value in dictionary.Values)
            {
                result.Add(value);
            }

            return result;
        }
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
