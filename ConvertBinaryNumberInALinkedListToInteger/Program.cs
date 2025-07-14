using DataStructures;

namespace ConvertBinaryNumberInALinkedListToInteger;

internal class Program
{
    private static int GetDecmialValue(ListNode head)
    {
        int result = 0;
        while (head != null)
        {
            result = (result << 1) | head.val;
            head = head.next;
        }
        return result;
    }
    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(0);
        head.next.next = new ListNode(1);
        int result = GetDecmialValue(head);
        Console.WriteLine(result);
    }
}
