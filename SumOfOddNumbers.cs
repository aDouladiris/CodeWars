#include <inttypes.h>

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
