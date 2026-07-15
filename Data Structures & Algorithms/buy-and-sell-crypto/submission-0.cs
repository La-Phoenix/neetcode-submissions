public class Solution {
    public int MaxProfit(int[] prices) {
        int left = 0; // Buy (most recent buy intent i.e min buy/left)
        int maxProfit = 0;
        if (prices.Length <= 1) return maxProfit;

        for (int right = 1; right < prices.Length; right++){
            if (prices[right] < prices[left]){
                left = right; // Update buy intent to less buy(cost)
                continue;
            }
            int currProfit = prices[right] - prices[left];
            maxProfit = Math.Max(maxProfit, currProfit);
        }
        return maxProfit;
    }
}
