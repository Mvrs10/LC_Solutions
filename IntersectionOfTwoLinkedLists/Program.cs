using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntersectionOfTwoLinkedLists
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }

    internal class Program
    {
        private static ListNode GetIntersectionNodeBruteForce(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            ListNode walkA = headA;
            ListNode walkB = headB;

            while (walkB != null)
            {
                while (walkA != null)
                {
                    if (walkA == walkB)
                    {
                        return walkA;
                    }
                    walkA = walkA.next;
                }
                walkA = headA;
                walkB = walkB.next;
            }
            return null;
        }
        private static ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            if (headA == null || headB == null) return null;
            ListNode walkA = headA;
            ListNode walkB = headB;
            int count = 0;
            while (walkA != walkB)
            {
                if (walkA == null)
                {
                    walkA = headB;
                }
                else
                {
                    walkA = walkA.next;
                }
                if (walkB == null)
                {
                    walkB = headA;
                }
                else
                {
                    walkB = walkB.next;
                }
                count++;
            }
            Console.WriteLine(count);
            return walkA;
        }
        static void Main(string[] args)
        {
            ListNode commonNode = new ListNode(8);

            ListNode headA = new ListNode(4);
            headA.next = new ListNode(1);           
            headA.next.next = commonNode;

            ListNode headB = new ListNode(5);
            headB.next = new ListNode(6);
            headB.next.next = new ListNode(1);
            headB.next.next.next = commonNode;

            commonNode.next = new ListNode(4);
            commonNode.next.next = new ListNode(5);

            ListNode result = GetIntersectionNodeBruteForce(headA, headB);
            result = GetIntersectionNode(headA, headB);
            Console.WriteLine(result.val);
        }
    }
}
