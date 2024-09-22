using System;

/// <summary>Contains methods to perform vector operations.</summary>
class VectorMath
{
    /// <summary>Calculates the sum of two vectors.</summary>
    /// <param name="vector1">First vector.</param>
    /// <param name="vector2">Second vector.</param>
    /// <returns>The sum of the vectors.</returns>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2 || vector1.Length == 3 && vector2.Length == 3)
        {
            for (int i = 0; i < vector1.Length; i++)
                vector1[i] += vector2[i];

            return vector1;
        }
        return new double[] { -1 };
    }
}
