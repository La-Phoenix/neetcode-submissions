public class Solution {
    public int LengthOfLongestSubstring(string s) {
        HashSet<char> seenWindowChars = new ();

        int right = 0, n = s.Length, maxLen = 0;

        for (int left = 0; left < n; left++){
            while(right < n && seenWindowChars.Add(s[right])){
                right++;
            }
            maxLen = Math.Max(maxLen, seenWindowChars.Count());
            seenWindowChars.Remove(s[left]);
        }

        return maxLen;
    }
}
