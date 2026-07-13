public class Solution {
    public int MaxArea(int[] heights) {
        int n = heights.Length;
        int left = 0;
        int right = n - 1;
        int maxArea = 0;

        while (left < right){
            int currArea = Math.Min(heights[left], heights[right]) * (right - left);
            maxArea = Math.Max(maxArea, currArea);

            if(heights[left] < heights[right]){
                left++;
                continue;
            }
            if(heights[left] > heights[right]){
                right--;
                continue;
            }
            // Both equal
            left++;
            right--;
        }

        return maxArea;
    }
}
