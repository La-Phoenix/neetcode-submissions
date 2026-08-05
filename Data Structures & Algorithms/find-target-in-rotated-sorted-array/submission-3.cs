public class Solution {
    public int Search(int[] nums, int target) {
        int n = nums.Length;

        int left = 0, right = n - 1;

        while (left <= right){
            int mid = left + (right - left) / 2;

            if (target == nums[mid]){
                return mid;
            }
            if (target == nums[left]){
                return left;
            }
            if (target == nums[right]){
                return right;
            }
            // At least one half is sorted
            if (nums[mid] > nums[right]){
                // right half (mid included) is not sorted, left half is
                // Check if target has a possibility of being in the left half
                if (target > nums[left] && target < nums[mid]) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            } else {
                // right half (mid included) is sorted
                if (target < nums[mid] || target > nums[right]) {
                    right = mid - 1;
                } else {
                    left = mid + 1;
                }
            }
        }

        return -1;
    }
}
