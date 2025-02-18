using System.Text;

namespace leetcode_problem_solving._228._Summary_Ranges
{
    public class Solution
    {
        public IList<string> SummaryRanges(int[] nums)
        {
            var result = new List<string>();
            var buffer = new List<string>();
            int i = 0;
            int cont = 0;
            while (i < nums.Length)
            {
                var current = nums[i];

                if (buffer.Any())
                {
                    // It means current is continuous 
                    if (cont + 1 == current)
                    {
                        buffer.Add(current.ToString());
                        cont = current;
                    }
                    else
                    {
                        Process(result, buffer);
                        i--;
                    }
                }
                else
                {
                    cont = current;
                    buffer.Add(current.ToString());
                }

                i++;
            }

            if (buffer.Any())
            {
                Process(result, buffer);
            }

            return result;
        }

        private static void Process(List<string> result, List<string> buffer)
        {
            var first = buffer.First();
            var last = buffer.Last();
            var range = first != last ? $"{first}->{last}" : last;
            result.Add(range);
            buffer.Clear();
        }
    }
}
