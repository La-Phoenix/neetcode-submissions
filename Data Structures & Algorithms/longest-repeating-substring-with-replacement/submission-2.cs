public class Solution {
    public int CharacterReplacement(string s, int k) {
        int n = s.Length;
        // Array to store counts of uppercase English letters (A-Z)
        int[] counts = new int[26]; 
        
        int left = 0;
        int maxRepeatCount = 0;
        int maxLen = 0;
        
        for (int right = 0; right < n; right++) {
            // Add the current character to the window frequency map
            counts[s[right] - 'A']++;
            
            // Track the maximum frequency of any single character seen in the current window
            maxRepeatCount = Math.Max(maxRepeatCount, counts[s[right] - 'A']);
            
            // Current window size is (right - left + 1)
            // If remaining characters to replace > k, shrink window from the left
            if ((right - left + 1) - maxRepeatCount > k) {
                counts[s[left] - 'A']--;
                left++;
            }
            
            // Calculate max length seen so far
            maxLen = Math.Max(maxLen, right - left + 1);
        }
        
        return maxLen;
    }
}
