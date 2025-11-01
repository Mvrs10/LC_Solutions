using DataStructures;
namespace DeleteNodesFromLinkedListPresentInArray;

internal class Program
{
    private static ListNode ModifiedList(int[] nums, ListNode head)
    {
        HashSet<int> set = new HashSet<int>(nums);

        while (set.Contains(head.val))
        {
            head = head.next;
        }

        ListNode current = head;

        while (current.next != null)
        {
            ListNode next = current.next;
            
            if (set.Contains(next.val))
            {
                current.next = next.next;
            }
            else
            {
                current = current.next;
            }
        }

        return head;
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
