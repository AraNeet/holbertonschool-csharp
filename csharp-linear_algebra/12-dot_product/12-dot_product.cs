using System;

/// <summary>
/// Class for vector operations
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that calculates dot product of two vectors
    /// </summary>
    /// <param name="vector1">First vector</param>
    /// <param name="vector2">Second vector</param>
    /// <returns>Dot product of two vectors</returns>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2 || vector1.Length == 3 && vector2.Length == 3)
        {
            double[] res = new double[vector1.Length];
            double sum = 0;

            for (int i = 0; i < vector1.Length; i++)
            {
                res[i] = vector1[i] * vector2[i];
            }

            foreach (var item in res)
            {
                sum += item;
            }
            return sum;
        }
        return -1;
    }
}
