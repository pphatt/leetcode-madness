public class Solution {
    public bool CheckValid(int[][] matrix) {
        int n = matrix.Length; // Number of rows
        if (matrix.Length == 0 || matrix[0].Length != n) return false; // Validate square matrix

        int[] rowCheck = new int[n + 1];
        int[] colCheck = new int[n + 1];

        for (int i = 0; i < n; i++)
        {
            Array.Clear(rowCheck, 1, n);
            Array.Clear(colCheck, 1, n);

            for (int j = 0; j < n; j++)
            {
                int rowNum = matrix[i][j];

                if (rowNum < 1 || rowNum > n || rowCheck[rowNum] == 1)
                {
                    return false;
                }

                rowCheck[rowNum] = 1;

                int colNum = matrix[j][i];

                if (colNum < 1 || colNum > n || colCheck[colNum] == 1)
                {
                    return false;
                }

                colCheck[colNum] = 1;
            }
        }

        return true;
    }
}
