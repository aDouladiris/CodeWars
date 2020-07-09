// Given the triangle of consecutive odd numbers:

//              1
//           3     5
//        7     9    11
//    13    15    17    19
// 21    23    25    27    29
// ...
// Calculate the row sums of this triangle from the row index (starting at index 1) e.g.:

// rowSumOddNumbers(1); // 1
// rowSumOddNumbers(2); // 3 + 5 = 8

uint64_t rowSumOddNumbers(uint32_t n)
{ 
  

  uint64_t x = (uint64_t)n;

  uint64_t sum = x*(x-1) + 1;

  uint64_t buf = 0;

  buf = sum;
  
  for (uint64_t i=1; i<x; i++)
  {
    
    sum = sum + 2;
    buf += sum;    
    
  }  
    
    return (uint64_t)buf;

  
    
}
