#include<stdio.h>
int main()
{
	int n1=10;
	int n2=33;
	char s[11];
	int n3=12;
	printf("Address of n1:%u\n",&n1);
	printf("Address of n2:%u\n",&n2);
	printf("Address of s:%u\n",s);
	printf("Address of n3:%u\n",&n3);
	printf("Enter a string:");
	gets(s);
	printf("n1=%d\n", n1);
	printf("n2=%d\n", n2);
	printf("String content:%s\n",s);
	printf("n1=%d\n", n3);
	getchar();
	return 0;
}
