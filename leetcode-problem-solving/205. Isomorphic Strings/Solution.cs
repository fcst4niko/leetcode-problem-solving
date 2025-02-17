using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._205._Isomorphic_Strings
{
    public class Solution
    {
        public bool IsIsomorphic(string s, string t)
        {
            if (s.Length != t.Length) return false;

            var map = new Dictionary<char, char>();

            for (int i = 0; i < t.Length; i++)
            {
                if (!map.ContainsKey(s[i]))
                {
                    if (map.ContainsValue(t[i]))
                    {
                        foreach (var item in map)
                        {
                            if (item.Value == t[i] && s[i] != item.Key)
                            {
                                return false;
                            }
                        }
                    }

                    map.Add(s[i], t[i]);
                }
                else
                {
                    var current = map[s[i]];

                    if (current != t[i])
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
