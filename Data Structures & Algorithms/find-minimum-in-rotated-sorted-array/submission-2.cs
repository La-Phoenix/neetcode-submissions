public class Solution {
    public int FindMin(int[] nums) {
        // Trivial soln is to do a linear search to where order breaks i.e min

        //Using Binary Search
        int n = nums.Length;
        int left = 0, right = n - 1;

        while (left < right) {
            int mid = left + (right - left) / 2;

            if (nums[mid] > nums[right]){
                left = mid + 1;
            } else {
                right = mid;
            }
        }

        return nums[left];
    }
}
