public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> seen = new();

        for(int i = 0; i < 9; i++){
            for(int j = 0; j < 9; j++){
                char number = board[i][j];
                if(number is '.') continue;

                string row = $"{number} row {i}";
                string col = $"{number} col {j}";
                string box = $"{number} box {i / 3}-{j/3}";

                if(!seen.Add(row)|| !seen.Add(col) || !seen.Add(box))
                    return false;
            }
        }
        return true;
    }
}