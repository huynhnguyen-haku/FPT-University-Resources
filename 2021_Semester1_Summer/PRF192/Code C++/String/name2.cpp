#include<stdio.h>
void print (char list[][31], int n)
{
	int i;
	for (i=0; i<n; i++) puts(list[i]);
}
int main()
{
	char names[7][31] = {"Dinh Tien Hoang", "Le Dai Hanh", "Ly Cong Uan","Le Loi", "Tran Nguyen Han","Le Thanh Tong","Nguyen Hue"};
	print(names, 7);
	getchar();
	return 0;
}
