#include <stdio.h>
int sumDivisors (int N) 
{ int i, s=0;
  for (i=1; i<=N/2; i++)
    if (N%i==0) s+=i;
  return s;
}
int main()
{ printf("Sum of divisors: %d\n", sumDivisors(15.7));
  getchar();
}
