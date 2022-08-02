
# 143 Reorder List

# O(N) Time, O(1) Space

class Solution:
    def reorderList(self, head: ListNode) -> None:

        # Find the 2nd half of the list.
        slow, fast = head, head.next
        while fast and fast.next:
            slow = slow.next
            fast = fast.next.next        

        # Reverse 2nd portion of the list.
        second = slow.next
        prev = slow.next = None
        while second:
            tmp = second.next
            second.next = prev
            prev = second
            second = tmp

        # Merge 2 halves
        first, second = head, prev
        while second: # we know 2nd half could be shorter
            tmp1, tmp2 = first.next, second.next
            first.next = second
            second.next = tmp1
            first, second = tmp1, tmp2





