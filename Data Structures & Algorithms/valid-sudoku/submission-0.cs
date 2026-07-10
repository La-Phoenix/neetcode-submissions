public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<char> row = new();
        HashSet<char> col = new();
        HashSet<char> square = new();

        for (int i = 0; i < board.Length; i ++){
            //row
            for (int j = 0; j < board[i].Length; j++){
                char val = board[i][j];
                if (char.IsDigit(val) && !row.Add(val)){
                    return false;
                }
            }
            row.Clear();

            // col
            for (int k = 0; k < board.Length; k++){
                char val = board[k][i];
                if (char.IsDigit(val) && !col.Add(val)){
                    return false;
                }
            }
            col.Clear();

            // square
            if (i % 3 != 0){
                continue;
            }

            for (int l = 0; l < board.Length / 3; l++){
                int m = i;
                while (m < i + 3){
                    char val = board[l][m];
                    if (char.IsDigit(val) && !square.Add(val)){
                        return false;
                    }
                    m++;
                }
            }
            square.Clear();
        }
        return true;
    }
}
