public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var orderedNumList = nums
        .GroupBy(num => num)
        .Select(group => new {
            Value = group.Key,
            Count = group.Count()
        })
        .OrderBy(group => group.Count)
        .ToList();

        int[] result = new int[k];
  
        for (int i = 1; i <= k; i ++){
            result[i-1] = orderedNumList[^i].Value;
        }
        return result;
    }
}
