public class Solution {
    public bool IsValidSudoku(char[][] board) {

        HashSet<string> seen = new HashSet<string>();

        for(int i = 0 ;  i < 9; i++)
        {
            for(int j=0; j < 9; j++)
            {
                char num  = board[i][j];
                if( num == '.')
                    continue;

                string row = num + " found in " + i;
                string column = num + "found in " + j;
                string box = num + "found in " + (i/3) + " - " + (j/3);

                if(!seen.Add(row) || !seen.Add(column) || !seen.Add(box))
                    return false; 
            }
        }

        return true;
    }
}
