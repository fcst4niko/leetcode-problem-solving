namespace leetcode_problem_solving._392._Is_Subsequence
{
    public class Solution
    {
        public bool IsSubsequence(string s, string t)
        {
            if (string.IsNullOrEmpty(s)) return true;
            if (string.IsNullOrEmpty(t)) return false;

            var i = 0;
            var buffer = t;
            while (i < s.Length)
            {
                var indexCurrent = buffer.IndexOf(s[i]);

                if (indexCurrent == -1) return false;

                buffer = buffer.Substring(indexCurrent + 1);

                i++;
            }

            return true;
        }
    }
}
