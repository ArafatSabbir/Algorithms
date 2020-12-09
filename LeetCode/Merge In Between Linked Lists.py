# Runtime: 448 ms, faster than 67.98% of Python3 online submissions for Merge In Between Linked Lists.
# Memory Usage: 20.1 MB, less than 36.51% of Python3 online submissions for Merge In Between Linked Lists.




class Solution:
    def mergeInBetween(self, list1: ListNode, a: int, b: int, list2: ListNode) -> ListNode:
        st, end = None, list1
        for i in range(b):
            if i == a - 1:
                st = end
            end = end.next
        st.next = list2
        while list2.next:
            list2 = list2.next
        list2.next = end.next
        end.next = None
        return list1
