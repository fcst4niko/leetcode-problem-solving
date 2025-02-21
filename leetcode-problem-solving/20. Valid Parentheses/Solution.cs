using System.Linq;

namespace leetcode_problem_solving._20._Valid_Parentheses
{
    public class Solution
    {
        public bool IsValid(string s)
        {
            if (s.Length < 1 || s.Length % 2 != 0 ) return false;

            var bracketStack = new Stack<char>();

            var bracketDictionary = new Dictionary<char, char>
            {
                { '(', ')' },
                { '{', '}' },
                { '[', ']' }
            };

            var i = 0;
            while (i < s.Length)
            {
                var currentChar = s[i];
                if (bracketDictionary.ContainsKey(currentChar))
                {
                    bracketStack.Push(currentChar);
                }
                else if (bracketStack.Any())
                {
                    var lastChar = bracketStack.First();
                    var lastClosingBracket = bracketDictionary[lastChar];

                    if (lastClosingBracket != currentChar)
                    {
                        return false;
                    }
                    bracketStack.Pop();
                }
                else
                {
                    return false;
                }

                i++;
            }

            return !bracketStack.Any();
        }
    }
}
