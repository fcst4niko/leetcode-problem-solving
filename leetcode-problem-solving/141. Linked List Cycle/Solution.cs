using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_problem_solving._141._Linked_List_Cycle
{

    //Definition for singly-linked list.
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    public class Solution
    {
        public bool HasCycle(ListNode head)
        {
            var nodeReference = new HashSet<ListNode>();

            while (head != null)
            {
                if (!nodeReference.Add(head)) return true;                

                head = head.next;
            }

            return false;
        }
    }
}
