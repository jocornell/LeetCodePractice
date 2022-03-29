// Linked List Implementation.

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }

    public void AppendNode(int val)
    {
        ListNode next = this;
        while (next.next != null)
        {
            next = next.next;
        }
        next.next = new ListNode(val, null);
    }
}