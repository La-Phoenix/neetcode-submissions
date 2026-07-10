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
        }

        // square
        for (int boxRow = 0; boxRow < board.Length; boxRow += 3){
            for (int boxCol = 0; boxCol < board.Length; boxCol += 3){
                for (int r = boxRow; r < boxRow + 3; r ++){
                    int c = boxCol;
                    while (c < boxCol + 3){
                        char val = board[r][c];
                        if (char.IsDigit(val) && !square.Add(val)){
                            return false;
                        }
                        c++;
                    }
                }
                square.Clear();
            }
        }
        return true;
    }
}
