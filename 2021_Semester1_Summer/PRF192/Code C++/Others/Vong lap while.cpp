#include<stdio.h>
int main ()
{ int n;
  int i=1;
  int sum1=0;
  printf("Hay nhap so n:");
  scanf("%d",&n);
  while (i<=n)
  {	sum1=sum1+i;
	i++;
  }
  printf("\nsum1=%d",sum1);
  getchar();
  return 0;
  }
