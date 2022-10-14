//String01.c - xem noi dung luu tru o mot chuoi
#include<stdio.h>
#include<conio.h>
int main()
{
	char S1[15] = "ABC";
	char S2[15] = {'a','b','c','\0'};
	int i;
	printf("Data luu tru cho S1:\n");
	for (i=0; i<15; i++) printf("%d", S1[i]);
	printf("\n");
	printf("Data luu tru cho S2:\n");
	for (i=0; i<15; i++) printf("%d",S2[i]);
	getch();
	return 0;
}
