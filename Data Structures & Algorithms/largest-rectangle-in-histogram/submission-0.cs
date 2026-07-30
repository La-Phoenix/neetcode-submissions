public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int n = heights.Length, maxArea = 0;
        Stack<int> deck = new();

        for (int right = 0; right < n; right++){
            int rightVal = heights[right];
            while (deck.TryPop(out int top)){
                if (rightVal < heights[top]){
                    int left = -1;
                    if(deck.TryPeek(out int newLeft)){
                        left = newLeft;
                    }
                    int currArea = heights[top] * (right - left - 1);
                    maxArea = Math.Max(maxArea, currArea);
                } else {
                    deck.Push(top);
                    if(right != heights[top]) {
                        deck.Push(right);
                    };
                    break;
                } 
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
