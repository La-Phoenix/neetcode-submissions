public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int numsLen = nums.Length;
        int[] prods = new int[numsLen];
        int[] prefixProds = new int[numsLen];
        int[] suffixProds = new int[numsLen];

        prefixProds[0] = 1;
        for (int i = 1; i < numsLen; i ++){
            prefixProds[i] = nums[i - 1] * prefixProds[i - 1];
        }

        suffixProds[^1] = 1;
        for (int i = numsLen - 2; i >= 0; i --){
            suffixProds[i] = nums[i + 1] * suffixProds[i + 1];
        }
        for (int i = 0; i < numsLen; i ++){
            prods[i] = prefixProds[i] * suffixProds[i]; 
        }
        return prods;
    }
}
