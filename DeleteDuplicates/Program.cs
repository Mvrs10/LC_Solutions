using System;

namespace DeleteDuplicates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Walk and delete!");
            ListNode head = new ListNode(0,
            new ListNode(0,
            new ListNode(1,
            new ListNode(1,
            new ListNode(1,
            new ListNode(2,
            new ListNode(2,
            new ListNode(3,
            new ListNode(3,
            new ListNode(4))))))))));

            ListNode result = DeleteDuplicates(head);
            Console.WriteLine("Debugging");
        }

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

        private static ListNode DeleteDuplicates(ListNode head)
        {
            ListNode walk = head;
            while (walk != null && walk.next != null)
            {
                ListNode nextNode = walk.next;
                if (walk.val == nextNode.val)
                {
                    walk.next = nextNode.next;             
                }
                else
                {
                    walk = nextNode;
                }                    
            }
            return head;
        }
    }
}
