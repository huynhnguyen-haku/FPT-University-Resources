/*Nhap vao hai so, tinh ra UCLN va BCNN*/
#include<stdio.h>
 int  gcd( int a, int b)
{ while ( a != b )
       if (a>b)
	   a -=b;
       else b -= a;
  return a;
}
int lcm ( int a, int b)
{ return a*b/ gcd(a,b);
}
int main ()
{ int a;
  int b;
  int d;
  int m; 
  printf("Please enter two positive integers:");
  scanf("%d%d", &a, &b); 
while (a<=0 or b<=0)
{ printf("Please enter positive integers(a,b>0)");
  scanf("%d%d", &a, &b);
}
 d = gcd(a, b);
 m = lcm(a, b);
 printf("Greatest common divisor:%d, Least common multuple:%d", d, m);
 return 0;
}
  
