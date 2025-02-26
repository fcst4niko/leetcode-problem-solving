// See https://aka.ms/new-console-template for more information

using leetcode_problem_solving._21._Merge_Two_Sorted_Lists;

Solution solution = new Solution();

ListNode list1 = new ListNode(2);
//ListNode list1 = new ListNode(1);
//list1.next = new ListNode(2);
//list1.next.next = new ListNode(4);

ListNode list2 = new ListNode(1);
//ListNode list2 = new ListNode(1);
//list2.next = new ListNode(3);
//list2.next.next = new ListNode(4);


var result = solution.MergeTwoLists(list1, list2);
while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}

Console.ReadLine();
