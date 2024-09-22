using System;

/// <summary>
/// Contains methods to perform matrix operations.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">The first matrix.</param>
    /// <param name="matrix2">The second matrix.</param>
    /// <returns>The resulting matrix. If the matrices cannot be multiplied, returns a matrix containing -1.</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return new double[,] { { -1 } };
        }
        double[,] matrix3 = new double[matrix1.GetLength(0), matrix2.GetLength(1)];
        double sum = 0;

        for (int rows1 = 0; rows1 < matrix1.GetLength(0); rows1++)
        {
            for (int col2 = 0; col2 < matrix2.GetLength(1); col2++)
            {
                sum = 0;
                for (int i = 0; i < matrix1.GetLength(1); i++)
                {
                    sum += matrix1[rows1, i] * matrix2[i, col2];
                }
                matrix3[rows1, col2] = sum;
            }
        }
        return matrix3;
    }
}
