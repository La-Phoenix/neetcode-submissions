public class Solution {
    public bool IsValid(string s) {
        int n = s.Length;
        if (n % 2 != 0){
            return false;
        }
        // Opening -> Closing
        Dictionary<char, char> parenthesis = new()
        {
            {'(',')'},
            {'{','}'},
            {'[',']'}
        };
        Stack<char> openingChars = new ();



        for (int i = 0; i < n; i++){
            if (parenthesis.ContainsKey(s[i])){
               openingChars.Push(s[i]);
            } else {
                if (openingChars.TryPop(out char openingChar)){
                    if(parenthesis[openingChar] != s[i]){
                        return false;
                    }
                    continue;
                }
                return false;
            }
        }

        return openingChars.Count > 0 ? false : true;
    }
}
