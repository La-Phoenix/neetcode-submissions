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
    public ListNode ReverseKGroup(ListNode head, int k) {
        ListNode dummy = new();
        ListNode kthPrev = dummy;
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null){
            // Find k-Group
            int count = k;
            ListNode kthNext = curr;
            while (count > 0){
                if (kthNext == null) break;
                kthNext = kthNext.next;
                count--;
            }
            if (count <= 0){
                // Reverse K-Group
                ListNode kStart = curr;
                while(curr != kthNext){
                    ListNode temp = curr.next;
                    curr.next = prev;
                    prev = curr;
                    curr = temp;
                }
                kthPrev.next = prev;
                kStart.next = curr;
                kthPrev = kStart;
                prev = null;
            } else {
                curr = kthNext;
            }
        }

        return dummy.next;
    }
}
