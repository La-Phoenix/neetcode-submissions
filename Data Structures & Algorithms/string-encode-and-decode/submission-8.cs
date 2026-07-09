public class Solution {

    public string Encode(IList<string> strs) {
        List<string> revStrs = new ();
        if (strs.Count < 1){
            return "";
        }
        foreach (string str in strs){
            char[] strChars = str.ToCharArray();
            if (str.Length < 1){
                Array.Resize(ref strChars, strChars.Length + 1);
                strChars[^1] = '^';
            }
            Array.Reverse(strChars);

            revStrs.Add(new String(strChars));
        }

        revStrs.Reverse();

        return string.Join("-", revStrs);
    }

    public List<string> Decode(string s) {
        List<string> encodedStrs = s.Split("-").ToList();
        List<string> decodedStrs = new ();
        if (s.Length < 1){
            return decodedStrs;
        }

        encodedStrs.Reverse();

        int emptyStrCount = 0;
        foreach (string encodedStr in encodedStrs){
            char[] strChars = encodedStr.ToCharArray();
            Array.Reverse(strChars);
            string str = new String(strChars);

            decodedStrs.Add((str.Length == 1 && str.EndsWith('^')) ? str[..^1] : str);
        }

        return decodedStrs;
   }
}
