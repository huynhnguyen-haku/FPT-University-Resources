/*Chuong trinh tim so lon nhat tu 2 so nguyen a, b*/
#include <stdio.h>
#include <conio.h>
int main (){
	int ia, ib, imax;
	printf("Nhap vao so a:");
	scanf("%d",&ia);
	printf("Nhap vao so b:");
	scanf("%d",&ib);
	imax=ia;
	if (ib>ia)
	imax = ib;
	printf("So lon nhat=%d\n", imax);
	getch();
}
