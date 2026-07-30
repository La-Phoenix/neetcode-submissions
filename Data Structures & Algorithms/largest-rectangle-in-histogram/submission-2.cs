public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length, maxArea = 0;
        Stack<int> deck = new();

        for (int right = 0; right < n; right++){
            int rightVal = heights[right];
            while (deck.Count > 0 && rightVal < heights[deck.Peek()]){
                int top = deck.Pop();
                int left = -1;
                if(deck.TryPeek(out int newLeft)){
                    left = newLeft;
                }
                int currArea = heights[top] * (right - left - 1);
                maxArea = Math.Max(maxArea, currArea);
            }
            deck.Push(right);
        }
        
        while (deck.TryPop(out int top)){
            int left = -1;
            if(deck.TryPeek(out int newLeft)){
                left = newLeft;
            }
            int currArea = heights[top] * (n - left - 1);
            maxArea = Math.Max(maxArea, currArea);
        }

        return maxArea;
    }
}
