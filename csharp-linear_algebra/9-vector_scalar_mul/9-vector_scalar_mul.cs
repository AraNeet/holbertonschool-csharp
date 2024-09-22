using System;

/// <summary>
/// Class for vector operations
/// </summary>
class VectorMath
{
    /// <summary>
    /// Method that multiplies a vector and a scalar and returns the resulting vector
    /// </summary>
    /// <param name="vector">double[] with the vector to multiply</param>
    /// <param name="scalar">double with the scalar to multiply</param>
    /// <returns>new double[] with the resulting vector</returns>
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] res = new double[vector.Length];
        if (vector.Length != 2 && vector.Length != 3)
            return new double[] {-1};

        for (int i = 0; i < vector.Length; i++)
        {
            res[i] = vector[i] * scalar;
        }
        return res;
    }
}
