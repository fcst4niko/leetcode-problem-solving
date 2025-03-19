using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace leetcode_problem_solving._138._Copy_List_with_Random_Pointer
{

    //Definition for a Node.
    public class Node
    {
        public int val;
        public Node next;
        public Node random;

        public Node(int _val)
        {
            val = _val;
            next = null;
            random = null;
        }
    }


    public class Solution
    {
        public Node CopyRandomList(Node head)
        {
            if (head == null) return null;

            Node current = head;
            Node copy = new Node(head.val);
            Node nextCopy = copy;

            while (current != null)
            {
                nextCopy.val = current.val;
                if (current.next != null)
                {
                    nextCopy.next = new Node(current.next.val);
                }

                nextCopy = nextCopy.next;
                current = current.next;
            }

            current = head;
            nextCopy = copy;

            while (current != null)
            {
                if (current.random != null)
                {
                    var pointer = FindPosition(head, current.random);
                    nextCopy.random = SearchNode(copy, pointer);
                }

                nextCopy = nextCopy.next;
                current = current.next;
            }

            return copy;
        }

        private int FindPosition(Node head, Node random)
        {
            var current = head;
            var pos = 0;

            if (current == random)
            {
                return 0;
            }

            while (current != null)
            {
                if (current == random)
                {
                    return pos;
                }

                pos++;
                current = current.next;
            }

            return pos;
        }

        private Node SearchNode(Node copy, int pointer)
        {
            var current = copy;
            var cont = 0;

            if (pointer == 0) return copy;

            while (current != null)
            {
                if (pointer == cont)
                {
                    return current;
                }

                cont++;
                current = current.next;
            }

            return copy;
        }
    }
}
