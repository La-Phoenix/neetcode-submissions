public class Solution {
    public int Trap(int[] height) {
        int maxArea = 0, left = 0, right = height.Length - 1;
        int leftMax = height[left], rightMax = height[right];

        while(left < right){
            // Left is the limiting factor, we cant get a heigher water level
            // Hence we push the left in
            if (height[left] <= height[right]){
                // Push first because leftMax already accounts current left
                left ++;
                leftMax = Math.Max(leftMax, height[left]);
                maxArea += leftMax - height[left];
            }

            // Right is the limiting factor, we cant get a heigher water level
            // Hence we push the right in
            if (height[left] > height[right]){
                // Push first because rightMax already accounts current right
                right --;
                rightMax = Math.Max(rightMax, height[right]);
                maxArea += rightMax - height[right];
            }
        }
        return maxArea;
    }
}
