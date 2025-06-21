using System;


namespace MergeTwoSortedLists
{
    public class ListNode
    {
        public int value;
        public ListNode next;
        public ListNode(int value = 0, ListNode next = null)
        {
            this.value = value;
            this.next = next;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merge them");
        }

        public ListNode MergeTwoList(ListNode l1, ListNode l2)
        {
            ListNode head = new ListNode();
            ListNode node = head;
            while (l1 != null && l2 != null)
            {
                if (l1.value <= l2.value)
                {
                    node.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    node.next = l2;
                    l2 = l2.next;
                }
                node = node.next;
            }
            if (l1 == null) node.next = l2;
            else node.next = l1;
            return head.next;
        }
    }
}

