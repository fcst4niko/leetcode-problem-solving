// See https://aka.ms/new-console-template for more information

using leetcode_problem_solving._71._Simplify_Path;

Solution solution = new Solution();

Console.WriteLine(solution.SimplifyPath("/home/"));
Console.WriteLine(solution.SimplifyPath("/home//foo/"));
Console.WriteLine(solution.SimplifyPath("/home/user/Documents/../Pictures"));
Console.WriteLine(solution.SimplifyPath("/../"));
Console.WriteLine(solution.SimplifyPath("/.../a/../b/c/../d/./"));
Console.WriteLine(solution.SimplifyPath("/"));
Console.WriteLine(solution.SimplifyPath("///"));

Console.ReadLine();
