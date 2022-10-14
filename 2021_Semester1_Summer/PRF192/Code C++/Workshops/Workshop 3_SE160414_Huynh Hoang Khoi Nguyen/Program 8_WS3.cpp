/*Nhap vao phan tich phan va phan so, khoi tao so thuc moi*/
#include<stdio.h>
double makeDouble(int ipart, int fraction)
{ double d_f= fraction;
  while (d_f >=1) d_f = d_f/10; /*Tao phan so be hon 1*/
  if (ipart<0) return ipart - d_f; /*Neu so am*/
  return ipart + d_f ; /*Neu so duong*/
}
int main()
{ int i, f;
  printf(" Please enter the integral part:");
  scanf("%d", &i);
  do
  { printf("Please enter the fraction part:");
    scanf("%d", &f);
  }
  while (f<0);
  double value = makeDouble(i,f);
  printf("The real number is:%lf",value);
  return 0;
}

  
