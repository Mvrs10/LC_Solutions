using DataStructures;
namespace ReverseLinkedList;

internal class Program
{
    private static ListNode ReverseListWithStack(ListNode head)
    {
        if (head == null) return head;
        Stack<ListNode> listNodes = new Stack<ListNode>();
        listNodes.Push(null);
        ListNode walk = head;
        while (walk != null)
        {
            listNodes.Push(walk);
            walk = walk.next;
        }
        head = listNodes.Pop();
        walk = head;
        while (walk != null)
        {
            walk.next = listNodes.Pop();
            walk = walk.next;
        }
        return head;
    }

    private static ListNode ReverseList(ListNode head)
    {
        if (head == null) return head;
        ListNode prev = null;
        ListNode current = head;
        while (current != null)
        {
            ListNode next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }

    private static ListNode RecursiveReverse(ListNode prev, ListNode current)
    {
        if (current == null) return prev;
        ListNode next = current.next;
        current.next = prev;
        return RecursiveReverse(current, next);
    }
    private static ListNode ReverseListRecursively(ListNode head)
    {
        return RecursiveReverse(null, head);
    }
    static void Main(string[] args)
    {
        ListNode head = new ListNode(1);
        head.next = new ListNode(2);
        head.next.next = new ListNode(3);
        head.next.next.next = new ListNode(4);
        head.next.next.next.next = new ListNode(5);
        head.next.next.next.next.next = new ListNode(6);
        head.next.next.next.next.next.next = new ListNode(7);

        head = ReverseListWithStack(head);
        Console.WriteLine(head.ToString());
        head = ReverseList(head);
        Console.WriteLine(head.ToString());
        head = ReverseListRecursively(head);
        Console.WriteLine(head.ToString());
    }
}
