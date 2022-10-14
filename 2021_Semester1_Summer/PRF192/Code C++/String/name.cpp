#include<stdio.h>
int main()
{
	char names[7][31] = {"Dinh Tien Hoang", "Le Dai Hanh", "Ly Cong Uan","Le Loi", "Tran Nguyen Han","Le Thanh Tong","Nguyen Hue"};
	int i;
	for (i=0; i<7; i++)
	printf("addr:%u, value:%s\n",&names[i],names[i]);
	getchar();
	return 0;
}
