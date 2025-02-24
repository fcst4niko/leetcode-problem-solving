namespace leetcode_problem_solving._290._Word_Pattern
{
    public class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            var words = s.Split(" ");

            if (words.Length != pattern.Length) return false;

            var dictionary = new Dictionary<char, string>();

            var i = 0;
            while (i < words.Length)
            {
                var currentPattern = pattern[i];
                var currentWord = words[i];

                if (dictionary.ContainsKey(currentPattern)
                    && dictionary[currentPattern] != currentWord)
                {
                    return false;
                }
                else if (!dictionary.ContainsKey(currentPattern))
                {
                    if (dictionary.ContainsValue(currentWord))
                    {
                        return false;
                    }

                    dictionary.Add(currentPattern, currentWord);
                }

                i++;
            }
            return true;
        }
    }
}
