// See https://aka.ms/new-console-template for more information

using leetcode_problem_solving._392._Is_Subsequence;

Solution solution = new Solution();

//string s = "abc", t = "ahbgdc";
//string s = "axc", t = "ahbgdc";
string s = "aaaaaa", t = "bbaaaa";

var result = solution.IsSubsequence(s, t);

Console.WriteLine(result);
Console.ReadLine();
