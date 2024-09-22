using System;

/// <summary>Contains methods to perform matrix operations.</summary>
class MatrixMath
{
    /// <summary>Method that adds two matrices and returns the resulting matrix.</summary>
    /// <param name="matrix1">First matrix to add.</param>
    /// <param name="matrix2">Second matrix to add.</param>
    /// <returns>The resulting matrix. If the matrices are not 2D or 3D, return a matrix containing -1.</returns>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        if (((matrix1.GetLength(0) == 2 && matrix1.GetLength(1) == 2) ||
            (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3)) &&
            matrix1.GetLength(0) == matrix2.GetLength(0))
        {
            int cols = matrix1.GetLength(0);
            int rows = matrix1.GetLength(1);
            double[,] sum = new double[cols, rows];

            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    sum[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return sum;
        }
        return new double[,] {{-1}};
    }
}
