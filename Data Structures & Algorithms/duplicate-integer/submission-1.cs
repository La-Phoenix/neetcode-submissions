

public class Solution {
    public bool hasDuplicate(int[] nums) {
        HashSet<int> uniqueNums = new();

        foreach (int num in nums){
            if (!uniqueNums.Add(num)){
                return true;
            }
        }
        return false;
    }
    // public bool hasDuplicate(int[] nums) {
    //     var groupedNums = nums
    //     .GroupBy(num => num)
    //     .Select(group => new {
    //         Value = group.Key,
    //         Count = group.Count()
    //     });

    //     foreach (var groupedNum in groupedNums){
    //         if (groupedNum.Count > 1){
    //             return true;
    //         }
    //     }
    //     return false;
    // }
}