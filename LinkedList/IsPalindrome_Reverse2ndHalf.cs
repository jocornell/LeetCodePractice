/*
 *  1 -> 2 -> 2 -> 1
 *  
 *  Stack solution: O(N) Time, O(N) Space
 *  
 *  
 *  Solutions --- Copy to ArrayList then use 2 pointers.
 *  Recursive
 *  
 *  
 *  Reverse Second Half in Place
 *  1 -> 2 -> 1 -> 2
 *  
 *  Get length.
 *  Advance pointer to middle.
 *  Reverse 2nd half of list.
 *  Advance pointer to middle.
 *  Check the list.
 */

// Accepted solution.
// Time O(N), Space O(1).
public class Solution
{
    public static bool isPalindrome(ListNode head)
    {
        int length = 0;
        ListNode current = head;
        ListNode middleNode = head;
        //ListNode prev = head;

        // Get length of list.
        while (current.next != null)
        {
            current = current.next;
            length++;
        }

        int middle = 0;
        if (length % 2 == 0)
            middle = (length / 2);
        else
            middle = (length / 2) + 1;

        current = head;

        // Advance to middle node.
        for (int i = 0; i < middle; i++)
        {
            //prev = current;
            current = current.next;
        }

        middleNode = current;

        middleNode = ReverseList(middleNode);
        //prev.next = middleNode;

        current = head;
        while (middleNode != null)
        {
            if (current == null)
                return false;

            if (current.val != middleNode.val)
                return false;

            current = current.next;
            middleNode = middleNode.next;
        }

        return true;
    }

    public static ListNode ReverseList(ListNode head)
    {
        if (head == null || head.next == null) return head;

        ListNode current = head;
        ListNode previous = head;
        ListNode next = head.next;

        while (next != null)
        {
            previous = current;
            current = next;
            next = next.next;

            current.next = previous;
        }

        head.next = null;
        return current;
    }

    static void Main(string[] args)
    {
        ListNode node = new ListNode(1, null);
        node.AppendNode(2);
        node.AppendNode(2);
        node.AppendNode(1);
        node.AppendNode(3);

    }

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

}

