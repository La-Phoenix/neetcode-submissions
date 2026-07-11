public class Solution {
    public bool IsValidSudoku(char[][] board) {
        // row index (i.e 0 - 8) -> index row set(i.e unique vals)
        Dictionary<int, HashSet<char>> rowsMap = new(); 
        // col index (i.e 0 - 8) -> index col set(i.e unique vals)
        Dictionary<int, HashSet<char>> colsMap = new(); 
        // sqaure index (i.e 0,0 - 2,2) -> index square set(i.e unique vals)
        Dictionary<string, HashSet<char>> squaresMap = new(); 

        for (int rowInd = 0; rowInd < 9; rowInd++){
            for (int colInd = 0; colInd < 9; colInd++){
                char cellVal = board[rowInd][colInd];
                if (!char.IsDigit(cellVal)) continue;
                string squareInd = (rowInd / 3) + "," + (colInd / 3);

                if (rowsMap.ContainsKey(rowInd) && rowsMap[rowInd].Contains(cellVal)
                    || colsMap.ContainsKey(colInd) && colsMap[colInd].Contains(cellVal)
                    || squaresMap.ContainsKey(squareInd) && squaresMap[squareInd].Contains(cellVal)){
                        return false;
                }

                if (!rowsMap.ContainsKey(rowInd)) {
                    rowsMap[rowInd] = new HashSet<char>();    
                }
                if (!colsMap.ContainsKey(colInd)) {
                    colsMap[colInd] = new HashSet<char>();    
                }
                if (!squaresMap.ContainsKey(squareInd)) {
                    squaresMap[squareInd] = new HashSet<char>();    
                }
                rowsMap[rowInd].Add(cellVal);
                colsMap[colInd].Add(cellVal);
                squaresMap[squareInd].Add(cellVal);
            }
        }

        return true;
    }
}
