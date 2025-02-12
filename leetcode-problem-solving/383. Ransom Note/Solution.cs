using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._383._Ransom_Note
{
    public class Solution
    {
        public bool CanConstruct(string ransomNote, string magazine)
        {
            var hashMap = new Dictionary<char, int>();

            for (int i = 0; i < magazine.Length; i++)
            {
                var currentChar = magazine[i];
                if (!hashMap.ContainsKey(currentChar))
                {
                    hashMap.Add(currentChar, 1);
                }
                else
                {
                    hashMap[currentChar] += 1;
                }
            }

            for (int i = 0; i < ransomNote.Length; i++)
            {
                var currentChar = ransomNote[i];

                if (!hashMap.ContainsKey(currentChar)
                    || (hashMap.ContainsKey(currentChar) && hashMap[currentChar] == 0))
                {
                    return false;
                }
                else if (hashMap.ContainsKey(currentChar) && hashMap[currentChar] > 0)
                {
                    hashMap[currentChar] -= 1;
                }
            }

            return true;
        }
    }
}
