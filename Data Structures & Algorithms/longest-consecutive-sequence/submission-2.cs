public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        if (n < 1) return  0;
        if (n == 1) return  1;

        // Eliminate duplicates and for O(1) lookups
        HashSet<int> numsSet = new HashSet<int>(nums);
        int longestSeq = 0;

        foreach (int num in nums){
            // Only start Count when its the start of a new seq 
            // i.e no predecessor
            // Prevents O(n2) time complexity
           if (!numsSet.Contains(num - 1)){
                // length of curr seq
                int len = 1;
                while (numsSet.Contains(num + len)) {
                    len++;
                }
                longestSeq = Math.Max(longestSeq, len);
           }
        }
        return longestSeq;
    }
}
