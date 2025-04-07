using System;
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
            IDictionary<string, IList<string>> dictionary = new Dictionary<string, IList<string>>();

            foreach (var item in strs)
            {
                var itemArray = item.ToCharArray();
                Array.Sort(itemArray);
                var itemSorted = new string(itemArray);

                if (dictionary.ContainsKey(itemSorted))
                {
                    dictionary[itemSorted].Add(item);
                }
                else
                {
                    dictionary.Add(itemSorted, new List<string> { item });
                }
            }

            return dictionary.Values.ToList();
        }
    }
}
