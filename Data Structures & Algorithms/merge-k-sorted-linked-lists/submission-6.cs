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
    public ListNode MergeKLists(ListNode[] lists) {
        int n = lists.Length;
        if (n == 0) return null;
        ListNode dummy = new();
        ListNode tail = dummy;
        // Min-heap (C# default) -> Node, Priority
        PriorityQueue<ListNode, int> heap = new();

        // Build heap
        for (int i = 0; i < n; i++){
            if(lists[i] != null){
                heap.Enqueue(lists[i], lists[i].val);
            }
        }

        // Build sorted list step by step by using heap to tell min at each step
        while (heap.Count > 0){
            ListNode minNode = heap.Dequeue();
            tail.next = minNode;
            if (minNode.next != null){
                heap.Enqueue(minNode.next, minNode.next.val);
            }
            tail = tail.next;
        }

        return dummy.next;
    }
}
