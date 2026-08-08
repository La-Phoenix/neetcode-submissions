public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        // Brute force soln is to combine both arrays, sort and find mid

        // Using binary search; 
        // over the possible partions of the 
        // smaller array to find the correct partionn
        int n = nums1.Length, m = nums2.Length;
        int numPartitions = Math.Min(n, m);
        int left = 0, right = numPartitions;
        int halfInd = (n + m + 1) / 2;
        int[] minArray = Math.Min(n, m) == n ? nums1 : nums2;
        int[] maxArray = Math.Max(n, m) == m ? nums2 : nums1;
        if (m == n && n == 0){
            return 0;
        }

        while (left <= right){
            int mid = left + (right - left) / 2;
            int rightPartLimit = (halfInd - mid) - 1;
            int leftPartLimit = mid - 1;
            int leftA = leftPartLimit >= 0 ? 
            minArray[leftPartLimit] : int.MinValue;
            int leftB = rightPartLimit >= 0 ? 
            maxArray[rightPartLimit] : int.MinValue;
            int rightA = mid > minArray.Length - 1 ? int.MaxValue : minArray[mid];
            int rightB = (rightPartLimit + 1) > maxArray.Length - 1 ? 
            int.MaxValue : maxArray[rightPartLimit + 1];

            if (leftB > rightA) {
                // i.e we took too little from minArray Partition
                // push partition to the right
                left = mid + 1;
            } else if (leftA > rightB) {
                // i.e we took too much from minArray Partition
                // push partition to the left
                right = mid - 1;
            } else {
                // We partitioned correctly
                if ((m + n) % 2 == 0){
                    // Even total array length
                    return (Math.Max(leftA, leftB) + Math.Min(rightA, rightB)) 
                    / (double)2;
                } else {
                    // Odd Array Length, median in left partion
                    return Math.Max(leftA, leftB);
                }
            }
        }
        return 0;
    }
}
