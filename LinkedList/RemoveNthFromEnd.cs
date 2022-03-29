// Can implement with dummy. Makes it cleaner. Can also implement recursively 
static ListNode RemoveNthFromEnd_SinglePass(ListNode head, int n)
{
    ListNode current = head;
    ListNode offset = head;

    if (head.next == null)
        return null;

    for (int i = 0; i < n; i++)
    {
        offset = offset.next;
    }

    if (offset == null)
    {
        head = head.next;
        return head;
    }

    while (offset.next != null)
    {
        current = current.next;
        offset = offset.next;
    }

    if (current.next.next != null)
        current.next = current.next.next;
    else
        current.next = null;

    return head;
}

static ListNode RemoveNthFromEnd_2PassSolution(ListNode head, int n)
{
    // Empty list -> return null;
    if (head.next == null)
        return null;

    // Get length.
    ListNode current = head;
    int length = 0;
    while (current.next != null)
    {
        current = current.next;
        length++;
    }

    int nthFromEnd = length - n + 1;

    // Only 2 elements in list -> remove head.
    if (nthFromEnd == 0)
    {
        head = head.next;
        return head;
    }

    current = head;
    for (int i = 0; i < nthFromEnd - 1; i++)
    {
        current = current.next;
    }

    // Check if next.next is null.
    if (current.next.next != null)
        current.next = current.next.next;
    else
        current.next = null;

    return head;
}
