public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int n = s1.Length, m = s2.Length;

        if (m < n) return false;

        char[] s1Chars = s1.ToCharArray();
        Array.Sort(s1Chars);

        int left = 0, right = n - 1;

        while (left < m){
            while (right < m){
                if (n == (right - left + 1)){
                    char[] sub = s2[left..(right + 1)].ToCharArray();
                    Array.Sort(sub);
                    if(s1Chars.SequenceEqual(sub)){
                        return true;
                    }
                    break;
                }
                right++;
            }
            left++;
        }

        return false;
    }
}
