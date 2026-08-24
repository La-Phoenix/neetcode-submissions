public class Solution {
    public int FindDuplicate(int[] nums) {
        // One posible soln: Sort and compare adjacent
        // Another using a hashset
        // Neither satisfies this problem's constraints

        // Using Floyd's Tortoise and hare's algorithm (Linked List Cycle detection)
        int tortoise = 0;
        int hare = 0;
        tortoise = nums[tortoise];
        hare = nums[nums[hare]];
        while (tortoise != hare){
            tortoise = nums[tortoise];
            hare = nums[nums[hare]];
        }

        tortoise = 0;
        while (tortoise != hare){
            tortoise = nums[tortoise];
            hare = nums[hare];
        }
        return tortoise;
    }
}
