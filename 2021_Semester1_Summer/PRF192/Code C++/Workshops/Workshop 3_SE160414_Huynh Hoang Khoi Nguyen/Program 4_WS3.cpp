/*Nhap vao mot so nguyen duong sau do in ra giai thua cua no*/
#include<stdio.h>
double factorial (int n)
{ double p=1;
  int i;
  for (i=2; i<=n; i++)
  p*=i;
  return p;
}
int main ()
{ int n;
   printf("Please enter a positive integer:");
   scanf("%d",&n);
  while (n<0)
  { printf("Please enter a positive integer (n>=0): ");
    scanf("%d",&n);
  }
printf("Factorial of %d = %f", n, factorial(n));
return 0;
}
