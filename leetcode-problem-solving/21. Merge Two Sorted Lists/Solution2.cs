using leetcode_problem_solving._141._Linked_List_Cycle;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._21._Merge_Two_Sorted_Lists
{

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution2
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {
            if (list1 == null && list2 != null) return list2;
            if (list1 == null && list2 == null) return list2;
            if (list1 != null && list2 == null) return list1;

            var root = new ListNode(list1.val);
            var resultList = root.next;
            var currentNode2 = list2;
            while (currentNode2 != null)
            {
                var currentNode = list1;
                while (currentNode != null)
                {
                    if (currentNode2.val < currentNode.val)
                    {
                        var auxNode = resultList;
                        resultList = new ListNode(currentNode2.val);
                        resultList.next = auxNode;
                        resultList = resultList.next;
                        break;
                    }
                    else if (currentNode2.val == currentNode.val)
                    {
                        var auxNode = currentNode.next; // it is the same currentNode
                        resultList.next = new ListNode(currentNode2.val);
                        resultList.next.next = auxNode != null ? new ListNode(auxNode.val) : auxNode;
                        resultList = resultList.next.next;
                        break;
                    }
                    currentNode = currentNode.next;
                }

                currentNode2 = currentNode2.next;
            }

            return root;
        }
    }
}
