public class Solution {
    public int LongestConsecutive(int[] nums) {
        int n = nums.Length;
        if (n < 1) return  0;
        if (n == 1) return  1;

        HashSet<int> numsSet = new();
        int lastMaxNum = 0;
        int numsSetCount = 0;

        Array.Sort(nums);

        foreach (int num in nums){
            if (num - lastMaxNum != 1 && num != lastMaxNum && numsSet.Count != 0){
                numsSetCount = Math.Max(numsSet.Count, numsSetCount);
                numsSet.Clear();
            }
            if(numsSet.Add(num)){                    
                lastMaxNum = num;
            };
        }

        numsSetCount = Math.Max(numsSet.Count, numsSetCount);
        return numsSetCount;
    }
}
