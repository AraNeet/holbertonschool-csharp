using System;

/// <summary>
/// Contains methods to perform matrix operations.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Transposes a matrix.
    /// </summary>
    /// <param name="matrix">The matrix to transpose.</param>
    /// <returns>The transposed matrix.</returns>
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transposedMatrix = new double[cols, rows];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                transposedMatrix[j, i] = matrix[i, j];
            }
        }
        return transposedMatrix;
    }
}
