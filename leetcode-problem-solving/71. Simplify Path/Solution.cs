using System.Reflection.Metadata.Ecma335;

namespace leetcode_problem_solving._71._Simplify_Path
{
    public class Solution
    {
        public string SimplifyPath(string path)
        {
            path = path.TrimEnd('/');

            if (path.Length <= 1 || !path.StartsWith('/')) return string.IsNullOrEmpty(path) ? "/" : path;

            string[] directories = GetDirectories(ref path);

            if (directories == null) return path;

            var stack = new Stack<string>();

            foreach (var dir in directories)
            {
                if (dir == "." || (dir == ".." && stack.Count < 1))
                {
                    continue;
                }
                else if (dir == ".." && stack.Count > 0)
                {
                    stack.Pop();
                }
                else
                {
                    stack.Push(dir);
                }
            }

            string simply = "/";
            while (stack.Count > 0)
            {
                simply = $"/{stack.Pop()}" + simply;
            }

            return simply.Length > 1 ?simply.TrimEnd('/') : simply;
        }

        private static string[] GetDirectories(ref string path)
        {

            while (path.Contains("//"))
            {
                path = path.Replace("//", "/");
            }

            var directories = path.Substring(1).Split("/");
            return directories;
        }
    }
}
