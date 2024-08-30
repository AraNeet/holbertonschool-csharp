using System;

namespace MyMath
{
  /// <summary>
  /// Represents a matrix utility class.
  /// </summary>
  public class Matrix
  {
    /// <summary>
    /// Divides all elements of a matrix.
    /// </summary>
    /// <param name="matrix">int[,]</param>
    /// <param name="num">int</param>
    /// <returns>Divided matrix</returns>
    public static int[,] Divide(int[,] matrix, int num)
    {
      try{
        for(int i = 0; i < matrix.GetLength(0); i++)
        {
          for(int j = 0; j < matrix.GetLength(1); j++)
          {
            matrix[i, j] = matrix[i, j] / num;
          }
        }
        return matrix;
      }catch(System.DivideByZeroException)
      {
        Console.WriteLine("Num cannot be 0");
        return null;
      }catch(System.NullReferenceException)
      {
        return null;
      }
    }
  } 
}