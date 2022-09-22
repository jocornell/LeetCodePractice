
# 203 Remove Linked List Elements


# Two Pointers

# Insert a dummy node in front of the list to avoid edge cases.
# memory O(1)   time O(N)


class ListNode:
    def __init__(self, val = 0, next = None) -> None:
        self.val = val
        self.next = next


class Solution:
    def removeElements(self, head: ListNode, val: int):
        dummy = ListNode(next = head)
        prev, curr = dummy, head

        while curr:
            nxt = curr.next

            if curr.val == val:
                prev.next = nxt
            else:
                prev = curr

            curr = nxt

        return dummy.next # new head



