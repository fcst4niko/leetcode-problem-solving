using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace leetcode_problem_solving._49._Group_Anagrams
{
    public class Solution3
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
                        break;
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
            if (s.Length != t.Length)
            {
                return false;
            }
            int[] saphabet = new int[26];
            foreach (char c in s)
            {
                saphabet[c - 'a']++;
            }
            foreach (char c in t)
            {
                if (saphabet[c - 'a'] > 0)
                {
                    saphabet[c - 'a']--;
                }
                else
                {
                    return false;
                }
            }
            return true;

        }
    }
}
