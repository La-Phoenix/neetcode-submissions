public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        // string sorted Value -> List of the corresponding Anagrams
        Dictionary<string, List<string>> sortedStrsMap = new ();

        foreach (string str in strs){

            char[] strChars = str.ToCharArray();
            Array.Sort(strChars);
            string sortedStr = new string(strChars);
            
            if (!sortedStrsMap.ContainsKey(sortedStr)){
                sortedStrsMap[sortedStr] = new List<string> {str};
            } else {
                sortedStrsMap[sortedStr].Add(str);
            }
        }

        return sortedStrsMap.Values.ToList();

        // // string sorted Value -> string's List index in List
        // Dictionary<string, int> sortedStrsMap = new ();
        // List<List<string>> result = new ();

        // for (int i = 0; i < strs.Length; i ++){

        //     char[] strChars = strs[i].ToCharArray();
        //     Array.Sort(strChars);
        //     string sortedStr = new string(strChars);
            
        //     if (!sortedStrsMap.TryAdd(sortedStr, result.Count)){
        //         int dupListInd = sortedStrsMap[sortedStr];
                
        //         result[dupListInd].Add(strs[i]);
        //     } else {
        //         result.Add(new List<string> {strs[i]});
        //     }
        // }

        // return result;
    }
}
