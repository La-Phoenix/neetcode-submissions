public class Solution {
    public int Trap(int[] height) {
        int maxArea = 0;
        int left = 0, right = height.Length - 1;
        int leftMax = height[left], rightMax = height[right];
        if (height.Length <= 1) return maxArea;

        while (left < right){
            if(height[left] <= height[right]){
                left++;
                leftMax = Math.Max(leftMax, height[left]);
                maxArea += leftMax - height[left];
            }
            if(height[left] > height[right]){
                right--;
                rightMax = Math.Max(rightMax, height[right]);
                maxArea += rightMax - height[right];
            }
        }
        return maxArea;
    }
}
