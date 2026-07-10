public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prods = new int[nums.Length];
        int totalProd = 1;

        int zeroCount = 0;
        foreach (int num in nums){
            if (num == 0){
                zeroCount += 1;
                continue;
            }
            totalProd *= num;
        }

        for (int i = 0; i < prods.Length; i ++){
            if (zeroCount == 1 && nums[i] == 0){
                prods[i] = totalProd;
                continue;
            }
            if (zeroCount >= 1){
                prods[i] = 0;
                continue;
            }
            prods[i] = totalProd / nums[i];
        }

        return prods;
    }
}
