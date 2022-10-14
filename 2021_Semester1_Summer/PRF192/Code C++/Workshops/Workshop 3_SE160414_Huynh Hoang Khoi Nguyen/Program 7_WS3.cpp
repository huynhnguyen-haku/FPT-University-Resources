/*Tong gia tri cua cac chu so trong 1 phan tu*/
#include<stdio.h>
int sumDigits (int n)
{ int sum=0; /*Khoi tao tong cac chu so*/
do
   { int remainder=n%10 ; /*Nhan mot chu so o vi tri don vi*/
     n=n/10;
     sum+=remainder;
   }
while (n>0);
return sum;
}
int main()

 { int S=0;
   int n;
   printf("Please enter a nonnegative integer:");
   scanf("%d",&n);
   if(n>=0)
  { S=sumDigits(n);
   printf("Sum of its decimal digits:%d\n", S);
  }
 while(n>=0);
 return 0;
}

