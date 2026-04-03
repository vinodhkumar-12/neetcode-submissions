public class NumMatrix {

    private int[,] prefix;

    public NumMatrix(int[][] matrix) {

        int matrixRow = matrix.Length;
        int matrixColumn = matrix[0].Length;

        prefix = new int[matrixRow+1, matrixColumn + 1];

        for(int i = 1; i <= matrixRow ;  i++)
        {
            for(int j = 1; j <= matrixColumn; j++)
            {
                prefix[i, j] = matrix[i-1, j-1] + prefix[i-1, j] + prefix[i, j-1] - prefix[i-1, j - 1];
            }
        }
    }
    
    public int SumRegion(int row1, int col1, int row2, int col2) {
        
        row1++;
        row2++;
        col1++;
        col2++;


        return prefix[row2,col2] - prefix[row2, col2 - 1]  - prefix[row1-1, col2] + prefix[row1-1, col1-1];
    }
}

/**
 * Your NumMatrix object will be instantiated and called as such:
 * NumMatrix obj = new NumMatrix(matrix);
 * int param_1 = obj.SumRegion(row1,col1,row2,col2);
 */