using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class TwoToOne 
{
  
  public static string Longest (string s1, string s2) 
  {
        String s3 = s1 + s2;
  
        Regex rg = new Regex("[a-zA-Z]");
  
        if ( rg.IsMatch(s3) ){        
  
          String sort_s3 = new string(s3.ToCharArray().Distinct().ToArray());        
  
          String ordered_s3 = String.Concat(sort_s3.OrderBy(_char => _char));
  
          return ordered_s3;
  
        }
        else{
          return "Wrong Input";
        }
  }
}
