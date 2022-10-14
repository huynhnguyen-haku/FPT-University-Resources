#include<stdio.h>
int main ()
{ int code;
  for (code=0; code < 256; code ++)
  { printf("%c : %d, %o, %X\n", code, code, code, code);
  }
  return 0;
 } 
