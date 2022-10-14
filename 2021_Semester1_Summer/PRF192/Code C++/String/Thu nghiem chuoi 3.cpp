//Thu nghiem chuoi
#include<stdio.h>
#include<string.h>
#include<conio.h>
int main()
{
	int n=10;
	char S[11] = "Hello";
	int m = 9;
	printf("n=%d, S=%s, m=%d\n", n, S, m);
	scanf("%10[^\n]",S);
    printf("n=%d, S=%s, m=%d\n", n, S, m);
    getch();
    return 0;
 } 
