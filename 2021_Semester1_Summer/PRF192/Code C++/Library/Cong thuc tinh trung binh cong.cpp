/*Tinh trung binh cong n so nguyen*/
#include<stdio.h>
#include<conio.h>
int main()
{ int ia[50], i, in, isum = 0;
  printf("Nhap vao gia tri n:");
  scanf("%d", &in);
  //Nhap du lieu vao mang
  for (i = 0; i < in; i++)
  {
  	printf("Nhap vao phan tu thu %d:", i + 1);
  	scanf("%d", &ia[i]); //Nhap vao gia tri cho phan tu thu i
  }
  //Tinh tong gia tri cac phan tu
  for (i = 0; i < in; i++)
     isum += ia[i];
  printf("Trung binh cong: %.2f\n", (float) isum/in);
  getch();
  return 0;
}
