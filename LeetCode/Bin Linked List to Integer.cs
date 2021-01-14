/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
     public int GetDecimalValue(ListNode head) 
     {
        int IntNum = 0;
        while(head != null)
        {
            IntNum = (IntNum * 2) + head.val;
            head = head.next;
        }
        return IntNum;
     }
}
