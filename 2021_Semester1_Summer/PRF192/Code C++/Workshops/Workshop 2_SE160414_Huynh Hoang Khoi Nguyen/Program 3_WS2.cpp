/*Sum of integers*/
#include<stdio.h>
#include<stdlib.h> 
int main ()
{ int x;
  int sum =0; /*Sum co gia tri ban dau bang 0*/
  printf("Nhap cac so nguyen, ket thuc chuoi bang 0\n");
  do
  { 
  printf("x=");
  scanf("%d", &x);
  if (x!=0)
  sum+=x;
  }
  while (x!=0);
  printf("Tong cac so nguyen = %d",sum);
  getchar ();
  return 0;
}
