namespace leetcode_problem_solving._21._Merge_Two_Sorted_Lists
{
    public class Solution
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 != null) return list2;
            if (list1 == null && list2 == null) return list2;
            if (list1 != null && list2 == null) return list1;

            var values = ExtractValues(list1);
            values.AddRange(ExtractValues(list2));
            var valuesArray = values.ToArray();
            Array.Sort(valuesArray);

            var root = new ListNode(valuesArray[0]);
            var current = root;

            for (int i = 1; i < valuesArray.Length; i++)
            {
                current.next = new ListNode(valuesArray[i]);
                current = current.next;
            }

            return root;
        }

        private static List<int> ExtractValues(ListNode currentList1)
        {
            var values = new List<int>();

            while (currentList1 != null)
            {
                values.Add(currentList1.val);

                currentList1 = currentList1.next;
            }

            return values;
        }
    }
}
