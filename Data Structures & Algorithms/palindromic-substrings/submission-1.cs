public class Solution {
    public int CountSubstrings(string s) {
        int count = 0;
        int ind = 0;
        // Around each possible palindrome center
        while (ind < s.Length){
            // Expand odd Palindrome
            count += Expand(s, ind, ind);
            // Expand even Palindrome
            count += Expand(s, ind, ind + 1);

            ind++;
        }
        return count;
    }

    private int Expand(string s, int left, int right){
        int count = 0;
        while (left >= 0 && right < s.Length && s[left] == s[right]){
            count ++;
            left--;
            right++;
        }
        return count;
    }


    // Sliding window approach wont work because as window expands a prior window might not
    // be a palindrome but the succeeding window should be
    // public int CountSubstrings(string s) {
    //     int left = 0;
    //     int right = 0;
    //     int count = 0;

    //     while (right < s.Length){
    //         while (right < s.Length && IsPalindrome(s[left..(right+1)])){
    //             count ++;
    //             right ++;
    //         }
    //         left ++;
    //     }
    //     return count;
    // }

    // public bool IsPalindrome(string s) {
    //     int left = 0;
    //     int right = s.Length - 1;

    //     while (left < right){
    //         while (!char.IsLetterOrDigit(s[left])) left ++;
    //         while (!char.IsLetterOrDigit(s[right])) right --;

    //         if (s[left] != s[right]) return false;

    //         left++;
    //         right--;
    //     }

    //     return true;
    // }
}