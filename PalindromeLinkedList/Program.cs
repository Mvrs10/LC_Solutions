namespace PalindromeLinkedList;
using DataStructures;

internal class Program
{
    private static ListNode ReverseHalfList(ListNode head, int size)
    {
        ListNode prev = null;
        ListNode current = head;
        int mid = size / 2;
        while (mid > 0)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
            mid--;
        }
        return prev;
    }
    private static bool IsPalindrome(ListNode head)
    {
        int count = 0;
        ListNode current = head;
        while (current != null)
        {
            count++;
            current = current.next;
        }
        current = head;
        for (int i = 0; i < count/2; i++)
        {
            current = current.next;
        }
        ListNode half = (count%2 == 0) ? current : current.next;
        head = ReverseHalfList(head, count);        
        while (half != null)
        {
            if (half.val != head.val) return false;
            head = head.next;
            half = half.next;
        }
        return true;
    }
    static void Main(string[] args)
    {
        ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(4))));
        ListNode head2 = new ListNode(0, new ListNode(3, new ListNode(4, new ListNode(3, new ListNode(0)))));
        bool result = IsPalindrome(head2);
        Console.WriteLine(result);
        result = IsPalindrome(head1);
        Console.WriteLine(result);
    }
}
