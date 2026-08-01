public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int colLen = matrix[0].Length;
        int n = matrix.Length * colLen;

        int left = 0, right = n - 1;
        while (left <= right){
            int mid = left + (right - left) / 2;
            int row = mid / colLen;
            int col = mid % colLen;

            if (target == matrix[row][col]){
                return true;
            } else if (target < matrix[row][col]){
                right = mid - 1;
            } else {
                left = mid + 1;
            }
        }

        return false;
    }
}
