using DataStructures;

namespace RemoveLinkedListElements;

internal class Program
{
    private static ListNode RemoveElements(ListNode head, int val)
    {        
        while (head != null && head.val == val)
        {
            head = head.next;
        }
        if (head == null) return head;
        ListNode walk = head;
        ListNode prev = walk;
        while (walk != null)
        {
            if (walk.val == val)
            {                
                prev.next = walk.next;
            }
            else
            {
                prev = walk;
            }                
            walk = walk.next!;
        }
        return head;
    }
    static void Main(string[] args)
    {
        ListNode head1 = new ListNode(2);
        ListNode node2 = new ListNode(2);
        ListNode node3 = new ListNode(2);
        ListNode node4 = new ListNode(2);
        int target = 2;

        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(6);
        head.next.next.next = new ListNode(3);
        head.next.next.next.next = new ListNode(4);
        head.next.next.next.next.next = new ListNode(5);
        head.next.next.next.next.next.next = new ListNode(6);

        ListNode result = RemoveElements(head1,2);
        Console.WriteLine(result.ToString());
    }
}
