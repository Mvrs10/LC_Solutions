using System.Text;

namespace DataStructures;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder("[");
        ListNode walk = this;
        while (walk != null)
        {
            sb.Append($" {walk.val} -> ");
            walk = walk.next;
        }
        sb.Append(" null ]");
        return sb.ToString();
    }
}
