public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<int> tempDeck = new();
        int n = temperatures.Length;
        int[] result = new int[n];

        for (int i = 0; i < n; i++){
            while (tempDeck.TryPop(out int tempInd)){
                if (temperatures[i] <= temperatures[tempInd]){
                    tempDeck.Push(tempInd);
                    break;
                }
                result[tempInd] = i - tempInd;
            }
            tempDeck.Push(i);
        }

        return result;
    }
}
