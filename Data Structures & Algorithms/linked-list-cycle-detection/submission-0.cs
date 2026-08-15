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
        if (head is null){
            return false;
        }
        ListNode tortoise = head;
        ListNode hare = head;
        tortoise = tortoise.next;
        hare = tortoise?.next;
        if (hare is null){
            return false;
        }
        while (hare != tortoise){
            tortoise = tortoise.next;
            hare = hare.next?.next;
            if (hare is null){
                return false;
            }
        }
        // Singly linked list is cyclic if hare catches up to tortoise
        return true;
    }
}
