public class Solution {
    public string MinWindow(string s, string t) {
        int n = s.Length, m = t.Length;
        Dictionary<char, int> tCounts = new();
        Dictionary<char, int> sCounts = new();
        int[] validWindow = {-1, -1};
        int minLen = int.MaxValue;

        if (n < m) return "";

        // Store t chars frequencies
        for (int i = 0; i < m; i++){
            if(!tCounts.TryAdd(t[i], 1)){
                tCounts[t[i]] ++;
            }
        }

        int need = tCounts.Count, matches = 0;

        int left = 0, right = 0;
        while (right < n){
            //Expand window to it's valid i.e contains t
            char rightChar = s[right];
            if (!sCounts.TryAdd(rightChar, 1)){
                sCounts[rightChar] ++;
            }
            // Check if char freq for curr window matches that of t
            if (tCounts.ContainsKey(rightChar) && 
            tCounts[rightChar] == sCounts[rightChar]){
                matches ++;
            }

            // While window contains shrink to get min window
            while (need == matches){
                char leftChar = s[left];
                int currLen = right - left + 1;
                if (currLen < minLen){
                    validWindow[0] = left;
                    validWindow[1] = right;
                    minLen = currLen;
                }

                sCounts[leftChar] --;
                if (tCounts.ContainsKey(leftChar) && sCounts[leftChar] < tCounts[leftChar]){
                    matches --;
                }
                left ++;
            }
            right++;
        }

        return minLen == int.MaxValue ? "" : s[validWindow[0]..(validWindow[1]+1)];
    }
}
