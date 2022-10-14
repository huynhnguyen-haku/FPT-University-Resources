/*Nhap vao mot so nguyen duong, kiem tra xem co thuoc day Fibonacci hay khong*/
#include<stdio.h>
int isFibonacci (int n)
{ int t1=1, t2=1, f=1;
  if (n==1) return 1; /*n thuoc day Fibonacci*/
  while (f<n) /*Tim cac so Fibo tu f toi n*/
  { f=t1 + t2;
    t1=t2;
    t2=f;
  }
  return n==f; /*Neu n==f thi n la phan tu Fibo*/
}
int main ()
{ int n;
  printf("Please enter a positive integer:");
  scanf("%d", &n);
  while (n<1)
   { printf("Please enter a positive number (n>=0):");
     scanf("%d",&n);
   }
   if (isFibonacci(n)==1)
   printf("It is a Fibonacci element.");
   else
   printf("It is not a Fibonacci element.");
   return 0;
}
