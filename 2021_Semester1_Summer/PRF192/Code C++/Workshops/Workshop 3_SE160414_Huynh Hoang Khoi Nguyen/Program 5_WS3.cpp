/*In ra gia tri o vi tri thu n trong day Fibonacci*/
#include<stdio.h>
double fibo (int n)
{ int t1=1, t2=1, f=1, i;
 for (i=3; i<=n; i++)
 {f=t1+t2;
  t1=t2;
  t2=f;
 }
 return f;
}
int main ()
{ int n;
  printf("Please enter n:");
  scanf("%d",&n);
  while (n<1)
   { printf("Please enter a positive number (n>=0):");
     scanf("%d",&n);
   }
printf("The value at the %d position in Fibonacci sequence is %f", n, fibo(n));
getchar ();
return 0;
}
