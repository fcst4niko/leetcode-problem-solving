// See https://aka.ms/new-console-template for more information

using leetcode_problem_solving._383._Ransom_Note;
using System.Diagnostics;

Solution Solution = new Solution();


//string ransomNote = "a", magazine = "b";
string ransomNote = "aa", magazine = "aab";
//string ransomNote = "aa", magazine = "ab";


Console.WriteLine(Solution.CanConstruct(ransomNote, magazine));

Console.ReadLine();
