using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListCycle
{
    internal class Program
    {
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

        private static bool HasCycle(ListNode head)
        {
            ListNode walk = head;
            List<ListNode> savedNodes = new List<ListNode>();
            while (walk != null)
            {
                if (savedNodes.Contains(walk))
                {
                    return true;
                }
                savedNodes.Add(walk);
                walk = walk.next;
            }
            return false;
        }

        private static bool HasCycleWithConstantMemory(ListNode head)
        {
            if (head == null || head.next == null)
            {
                return false;
            }
            ListNode walk = head;
            ListNode run = head.next;
            while (run != null)
            {
                if (walk == run)
                {
                    return true;
                }
                walk = walk.next;
                if (run.next == null)
                {
                    break;
                }
                run = run.next.next;
            }
            return false;
        }
        static void Main(string[] args)
        {
            ListNode head = new ListNode(3);
            ListNode node2 = new ListNode(2);
            ListNode node3 = new ListNode(0);
            ListNode node4 = new ListNode(-4);
            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node2;
            bool result = HasCycle(head);
            Console.WriteLine(result);

            result = HasCycleWithConstantMemory(head);
            Console.WriteLine(result);

            ListNode a = new ListNode(1);
            ListNode b = new ListNode(2);
            a.next = b;
            b.next = a;
            result = HasCycle(a);
            Console.WriteLine(result);
        }
    }
}
