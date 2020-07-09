 

using System;
using System.Linq;

public class Dubstep
    {
        public static string SongDecoder(string input)
        { 
          String n = input.Replace("WUB", " ");
          return string.Join( " ", n.Split( new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries ));
        }
    }
