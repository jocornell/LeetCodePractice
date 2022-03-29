// Fast Pointer + slow pointer approach.
// Time: O(N). Space O(1)
static bool HasCycle(ListNode head)
{
    ListNode slowPointer = head;
    ListNode fastPointer = head;

    if (head == null || head.next == null) return false;

    while (fastPointer.next != null && fastPointer.next.next != null)
    {
        slowPointer = slowPointer.next;
        fastPointer = fastPointer.next.next;

        if (slowPointer == fastPointer)
        {
            return true;
        }
    }

    return false;
}