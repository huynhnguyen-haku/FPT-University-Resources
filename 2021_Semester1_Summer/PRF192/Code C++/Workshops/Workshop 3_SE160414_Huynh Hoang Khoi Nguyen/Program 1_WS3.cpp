/*Nhap vao so duong n >2, sau do in ra cac so nguyen to tu 2 den n*/ 
 #include <stdio.h>
 #include <math.h>
 int  prime( int n )
{    int m = sqrt(n); /*m: can bac hai cua n*/
       int i; /*bien co gia tri tu 2 den m*/
     if (n<2) return 0;  /*dieu kien 1 khong duoc thoa man*/
     for ( i=2; i<=m; i++) /*kiem tra dieu kien 2*/
         if (n%i==0) return 0; /*neu n chia het cho i thi khong phai so nguyen to*/
     return 1; /*neu n chia i co du thi la so nguyen to*/
}
int main()
{ int n,i;
  printf("Enter an integer: ");
  scanf("%d",&n);
 while (n<2)
{ printf("Please enter an integer n, n>=2: ");
  scanf("%d",&n);
}
printf("Prime numbers from 2 to %d are:", n);
for (int i=2;i<=n;i++)
if (prime(i))
printf("%d ",i);
return 0;
}

