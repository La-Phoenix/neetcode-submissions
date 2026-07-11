public class Solution {
    public bool IsPalindrome(string s) {
        if (s.Length <= 1) return true;
        List<char> strValidChars = new();
        string lowerS = s.ToLower();

        foreach (char c in lowerS){
            if (char.IsLetterOrDigit(c)){
                strValidChars.Add(c);
            }
        }

        char[] strValidCharsArr = strValidChars.ToArray();
        lowerS = new string(strValidCharsArr);
        Array.Reverse(strValidCharsArr);
        string revLowerS = new string(strValidCharsArr);

        if (string.Equals(revLowerS, lowerS)){
            return true;
        }
        return false;
    }
}
