using DataStructures;

namespace AddTwoNumbers;

internal class Program
{
    private static ListNode AddTwoNumber(ListNode l1, ListNode l2)
    {
        ListNode l3 = new ListNode();
        ListNode current = l3;
        int carry = 0;

        while (l1 != null || l2 != null || carry == 1)
        {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            current.next = new ListNode(sum % 10);
            carry = sum / 10;

            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }

        return l3.next;
    }

    private static ListNode AddTwoNumber_v2(ListNode l1, ListNode l2)
    {
        ListNode l3 = new ListNode();
        ListNode current = l3;
        int carry = 0;

        while (true)
        {
            int sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            current.val = sum % 10;
            carry = sum / 10;

            l1 = l1?.next;
            l2 = l2?.next;

            if (l1 == null && l2 == null && carry == 0) break;
            current.next = new ListNode();
            current = current.next;
        }

        return l3;
    }

    static void Main(string[] args)
    {
        ListNode l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
        ListNode l2 = new ListNode(5, new ListNode(6, new ListNode(4)));

        ListNode result = AddTwoNumber(l1, l2);
     
        while (result != null)
        {
            Console.Write($"{result.val}->");
            result = result.next;
        }
        Console.Write("null"+ Environment.NewLine);

        l1 = new ListNode(9, new ListNode(1, new ListNode(5)));
        l2 = new ListNode(1, new ListNode(8, new ListNode(5)));

        result = AddTwoNumber_v2(l1, l2);
        while (result != null)
        {
            Console.Write($"{result.val}->");
            result = result.next;
        }
        Console.Write("null");
    }
}
