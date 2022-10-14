#include <stdio.h>
int main ()
{ int n, i;
  printf ("Hay nhap so n:");
  scanf ("%d",&n);
  int sum1 =0;
  for (i=1; i<=n;i++) sum1 += i;
  printf ("\nsum1=%d", sum1);
  getchar(); getchar();
  return 0;
 } 
