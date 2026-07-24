public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        int n = nums.Length;
        int numWinds = n - k + 1;
        int[] res = new int[numWinds];
        LinkedList<int> windowDeque = new();
        

        int left = 0, right = 0;
        while (right < n){
            // Maintain a monotone decreasing deque
            while (windowDeque.Count > 0 && nums[windowDeque.Last.Value] < nums[right]){
                windowDeque.RemoveLast();
            }
            windowDeque.AddLast(right);

            // Remove expired deque value
            if (left > windowDeque.First.Value){
                windowDeque.RemoveFirst();
            }
            
            // Window is at limit or exceeded
            if ((right + 1) >= k){
                res[left] = nums[windowDeque.First.Value];
                left ++;
            }
            right ++;
        }
        return res;
    }
}
