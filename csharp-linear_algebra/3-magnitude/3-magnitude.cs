using System;

/// <summary>
/// Class VectorMath.
/// </summary>
class VectorMath
{
    /// <summary>
    /// Calculates the magnitude of a 2D or 3D vector.
    /// </summary>
    /// <param name="vector">vector to check</param>
    /// <returns>returns the length of a given vector</returns>
    public static double Magnitude(double[] vector)
    {
        double res = 0;

        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        for (int i = 0; i < vector.Length; i++)
        {
            vector[i] *= vector[i];
        }

        foreach (var item in vector)
        {
            res += (double)item;
        }

        return Math.Round(Math.Sqrt(res), 2);
    }
}
