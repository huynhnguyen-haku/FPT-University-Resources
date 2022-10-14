#include<stdio.h>
int main ()
{ double x = 0.5;
  double* pD = &x;
  int i;
  for (i=-2; i<=2; i++)
     printf("%u,", pD+i);
     printf("\n");
  int n = 3;
  int *pI = &n;
  for (i=-2; i<=2; i++)
     printf("%u,", pI+i);
     printf("\n");
  pI++;
     printf("%u\n", pI);
  pI--;
     printf("%u\n", pI);
  getchar();
  return 0;n
}
