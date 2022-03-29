class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

/*
    Traverse list.
    Maintain prev pointer.
    Point current to prev.
    Will need some kind of temp var to update prev.

    Had to trace algo...
    Current,   Prev,    Next

    1           1       2
    2           1       3        // Update 2 -> 1

    --

    2           1       3
    3           2       4        // Update 3 -> 2

    --
    .
    .
    .

    --
    4           3       5
    5           4       null    // update 5 -> 4
*/

// Time: O(n), Space: O(1)
class Solution
{
    public ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null) return head;     

        ListNode current = head;
        ListNode previous = head;
        ListNode next = head.next;

        while (next != null){

            previous = current;
            current = next;
            next = next.next;

            current.next = previous;
        }

        head.next = null;
        return current;
    }

    // A helpful explanation.
    // https://leetcode.com/problems/reverse-linked-list/discuss/1711202/Detailed-explanation-of-recursive-solution-+-alternate-simpler-recursive-solution

    // Time: O(n), Space: O(n)
    public ListNode ReverseListRecursive(ListNode head){
        
        if (head == null || head.next == null) 
            return head;

        ListNode p = ReverseList(head.next);

        head.next.next = head;
        head.next = null;

        return p;
    }
}


