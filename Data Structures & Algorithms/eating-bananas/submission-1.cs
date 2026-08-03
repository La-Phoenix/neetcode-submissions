public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        int n = piles.Length;
        int left = 1, right = piles.Max();
        int rate = right;

        while (left <= right){
            int mid = left + (right - left) / 2;

            long totalTime = 0;
            foreach (int pile in piles){
                totalTime += (int)Math.Ceiling(pile / (decimal)mid);
            }

            if (totalTime <= h){
                rate = mid;
                // Koko ate with given time, let's see if koko can slower
                right = mid - 1;
            } else {
                // Koko ate too slow, eat faster
                left = mid + 1;
            }
        }

        return rate;
    }
}
