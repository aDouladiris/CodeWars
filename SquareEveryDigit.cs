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
