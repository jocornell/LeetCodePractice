
public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{

    static ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null) return list2;
        if (list2 == null) return list1;

        ListNode currentList1Index = list1;
        ListNode currentList2Index = list2;
        ListNode current = new ListNode();


        // Set head of merged list.
        if (list1.val < list2.val)
        {
            current.val = list1.val;
            currentList1Index = currentList1Index.next;
        }
        else
        {
            current.val = list2.val;
            currentList2Index = currentList2Index.next;
        }

        ListNode mergedList = current;


        // Build merged list.
        while (currentList1Index != null && currentList2Index != null)
        {
            if (currentList1Index.val < currentList2Index.val)
            {
                current.next = currentList1Index;
                currentList1Index = currentList1Index.next;
            }
            else
            {
                current.next = currentList2Index;
                currentList2Index = currentList2Index.next;
            }

            current = current.next;
        }


        // If the end of one list is reached, then append the other list.
        if (currentList1Index == null)
        {
            while (currentList2Index != null)
            {
                current.next = currentList2Index;
                currentList2Index = currentList2Index.next;
                current = current.next;
            }
        }
        else
        {
            while (currentList1Index != null)
            {
                current.next = currentList1Index;
                currentList1Index = currentList1Index.next;
                current = current.next;
            }
        }



        return mergedList;
    }

}
