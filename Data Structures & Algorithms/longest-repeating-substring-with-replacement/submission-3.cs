public class Solution {
    public int CharacterReplacement(string s, int k) {
        HashSet<char> charSet = new HashSet<char>(s);
        int maxLen = 0;
        if (s.Length <= 1) return 1;

        foreach (char c in charSet){
            int left = 0, count = 0;
            // Create a window to calculate max substring len for current unique char
            for (int right = 0; right < s.Length; right ++){
                if (s[right] == c){
                    // Count current unique char occurrence as window expands
                    count ++;
                }

                // Compute window validity i.e windowLen - count
                // and shrink window if k replacements cant make up for window invalidity
                while ((right - left + 1) - count > k){
                    if (s[left] == c) {
                        count --;
                    }
                    left ++;
                }
                maxLen = Math.Max(maxLen, right - left + 1);
            }
        }
        return maxLen;
    }
}
