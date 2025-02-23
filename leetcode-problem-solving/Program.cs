// See https://aka.ms/new-console-template for more information

using leetcode_problem_solving._290._Word_Pattern;

Solution solution = new Solution();

//string pattern = "abba", s = "dog cat cat dog";
//string pattern = "abba", s = "dog cat cat fish";
//string pattern = "aaaa", s = "dog cat cat dog";
string pattern = "abba", s = "dog dog dog dog";

Console.WriteLine(solution.WordPattern(pattern, s));

Console.ReadLine();
