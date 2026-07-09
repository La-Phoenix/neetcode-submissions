public class Solution {
    public bool IsAnagram(string s, string t) {
        if (s.Length != t.Length) return false;
        string tCopy = t;
        for (int i = 0; i < s.Length; i++){
            if (!tCopy.Contains(s[i])){
                return false;
            }
            int j = tCopy.IndexOf(s[i]);
            tCopy = tCopy.Remove(j, 1);
        }
        return true;
    }
}
