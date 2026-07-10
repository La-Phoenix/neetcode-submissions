public class Solution {

    public string Encode(IList<string> strs) {
        if (strs.Count < 1){
            return "";
        }

        StringBuilder mutStr = new();

        foreach (string str in strs){
            mutStr.Append(str.Length).Append("#").Append(str);
        }

        return mutStr.ToString();
    }

    public List<string> Decode(string s) {
        List<string> decodedStrs = new();
        List<int> prevStrsEnds = new();

        int sLen = s.Length;

        if (sLen < 1){
            return decodedStrs;
        }

        for (int i = 0; i < sLen; i++){
            if (s[i] == '#'){
                string strLenStr = "";
                if (prevStrsEnds.Count < 1){
                    strLenStr = s[..i];
                } else if (prevStrsEnds[^1] < i) {
                    strLenStr = s[(prevStrsEnds[^1])..i];
                }
                if (!int.TryParse(strLenStr, out int strLen) || strLen < 0){
                    continue;
                }
                int startInd = i + 1;
                int endInd = startInd + strLen;
                if (endInd <= sLen){
                    decodedStrs.Add(s[startInd..endInd]);
                    prevStrsEnds.Add(endInd);
                }
            }
        }

        return decodedStrs;
   }
}
