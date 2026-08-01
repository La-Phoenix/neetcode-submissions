public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // Two Phase binary search
        int rowLen = matrix.Length;
        int colLen = matrix[0].Length;

        int left = 0, right = rowLen - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            int last = colLen - 1;
            if (target == matrix[mid][0] || target == matrix[mid][last]){
                return true;
            } else if (target < matrix[mid][0]){
                right = mid - 1;
            } else if (target > matrix[mid][last]){
                left = mid + 1;
            } else {
                int innerLeft = 0, innerRight = colLen - 1;
                while (innerLeft <= innerRight){
                    int innerMid = innerLeft + (innerRight - innerLeft) / 2;
                    if (target == matrix[mid][innerMid]){
                        return true;
                    } else if (target < matrix[mid][innerMid]){
                        innerRight = innerMid - 1;
                    } else {
                        innerLeft = innerMid + 1;
                    }
                }
                return false;
            }
        }

        return false;
    }
}
