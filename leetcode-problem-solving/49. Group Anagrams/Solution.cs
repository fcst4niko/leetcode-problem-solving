using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._49._Group_Anagrams
{
    public class Solution
    {
        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            IList<IList<string>> result = new List<IList<string>>();
            HashSet<int> index = new HashSet<int>();

            for (int i = 0; i < strs.Length; i++)
            {
                if (index.Contains(i)) continue;
                var innerList = new List<string>();

                innerList.Add(strs[i]);

                for (int j = i + 1; j < strs.Length; j++)
                {
                    if (index.Contains(j)) continue;
                    if (i != j)
                    {
                        if (IsAnagram(strs[i], strs[j]))
                        {
                            innerList.Add(strs[j]);
                            index.Add(j);
                        }
                    }
                }
                index.Add(i);
                result.Add(innerList);
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
