using System;

class Number
{
  public static int PrintLastDigit(int number)
  {
    if(number < 0){
      number = -number;
    }
    int last_digit = number % 10;
    Console.Write(last_digit);
    return last_digit;
  }
}