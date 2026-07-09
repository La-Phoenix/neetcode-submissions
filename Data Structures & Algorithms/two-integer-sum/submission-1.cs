public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> numMaps = new ();

        for (int i = 0; i < nums.Length; i ++){
            numMaps[nums[i]] = i;
        }

         for (int i = 0; i < nums.Length; i ++){
            int diff = target - nums[i];
            if (numMaps.ContainsKey(diff) && numMaps[diff] != i){
                return new int[] {i, numMaps[diff]};
            }
        }
        return null;
    }
}
