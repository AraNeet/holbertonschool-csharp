using System;
using System.Collections.Generic;

class Int
{
  public static void divide(int a, int b)
  {
  int div = 0;
    try{
      div = a / b;
    }
    catch(System.DivideByZeroException)
    {
      Console.WriteLine("Cannot divide by zero");
    }
    finally{
      Console.WriteLine($"{a} / {b} = {div}");
    }
  }
}
