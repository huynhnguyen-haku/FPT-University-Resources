#include <stdio.h>
int main ()
{ int n=7, m=6;
  int*pn = &n;
  int*pm = &m;
  *pn = 2*(*pm) + m*n;
  *pm += 3*m - (*pn);
  printf("m=%d, n=%d\n", m, n);
  getchar();
  return 0;
}
