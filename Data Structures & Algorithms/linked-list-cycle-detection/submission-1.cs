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
    public bool HasCycle(ListNode head) {
        // Instead of maintaining the nodes in a hashset to detect duplicate 
        // i.e cycle point. We use Floyd's Tortoise and Hare Algorithm
        ListNode tortoise = head;
        ListNode hare = head;
        
        while (hare?.next is not null){
            tortoise = tortoise.next;
            hare = hare.next.next;
            if (hare == tortoise){
                return true;
            }
        }
        return false;
    }
}
