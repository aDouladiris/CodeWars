// Welcome. In this kata, you are asked to square every digit of a number.

// For example, if we run 9119 through the function, 811181 will come out, because 92 is 81 and 12 is 1.

// Note: The function accepts an integer and returns an integer

using System;

public class Kata
{
  public static int SquareDigits(int n)
  {
    String new_n = n.ToString();

    String buffer = "";
    
    foreach (char c in new_n){

      int x = (int)(Char.GetNumericValue(c));

      double pow_x = Math.Pow(x, 2); 

      int pow_x_int = (int)pow_x;

      String x_str = pow_x_int.ToString();

      buffer += x_str ;
      
    }

    Int32 returning_x = Int32.Parse(buffer);
    
    return returning_x;
  }
}
