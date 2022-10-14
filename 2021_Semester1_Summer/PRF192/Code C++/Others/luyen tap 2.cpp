/*Uoc chung lon nhat va boi chung nho nhat*/ 
#include<stdio.h>
int gcd (int value1, int value2)
{ while (value1 != value2)
  if (value1>value2)
        value1-= value2;
  else  value2-= value1;
  return value1;
}
int lcm (int value1, int value2)
{ return (value1*value2)/gcd(value1, value2);
}
int main ()
{ int m, n, L, G;
  do
  { printf("Input 2 positives interger:");
    scanf("%d%d", &m, &n);
  }
while (m<=0 || n<=0);
G = gcd(m, n);
L = lcm(m, n);
printf ("GCD:%d, LCM:%d\n", G, L);
getchar ();
getchar ();
return 0; 
}
