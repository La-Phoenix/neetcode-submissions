public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        // Array of alphabets char counts such that each alpha-char is rep with
        // an arr index corresponding to their numeric equivalent
        int[] s1Counts = new int[26];
        int[] s2Counts = new int[26];
        int n = s1.Length, m = s2.Length;

        if (m < n) return false;

        // First window in s2 corresponding to s1 len
        // Count their alpha-chars frequencies
        for (int i = 0; i < n; i++){
            s1Counts[s1[i] - 'a'] ++;
            s2Counts[s2[i] - 'a'] ++;
        }

        // Find matches in 26 alpha-chars for both
        int matches = 0;
        for (int i = 0; i < 26; i++){
            if (s1Counts[i] == s2Counts[i]){
                matches++;
            }
        }

        // New windows
        int left = 0;
        for (int right = n; right < m; right ++){
            if (matches == 26){
                return true;
            }

            // On expansion
            // Increase frequency of expansion char - right index
            int charInd = s2[right] - 'a';
            s2Counts[charInd] ++;
            // Effect of char freq count increase. Match/Mismatch
            if (s2Counts[charInd] == s1Counts[charInd]){
                matches ++;
            } else if (s1Counts[charInd] + 1 == s2Counts[charInd]){
                matches --;
            }

            //On Contraction
            // Decrease frequency of contraction char - left index
            charInd = s2[left] - 'a';
            s2Counts[charInd] --;
            // Effect of char freq count decrease. Match/Mismatch
            if (s1Counts[charInd] == s2Counts[charInd]){
                matches ++;
            } else if (s1Counts[charInd] - 1 == s2Counts[charInd]){
                matches --;
            }
            left ++;
        }

        return matches == 26;
    }
}
