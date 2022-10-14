#include<stdio.h>
void fun1(int a, int b)
{
	a+1;
	b+1;
}
int main()
{
	int x = 5, y = 10;
	fun1(x, y);
	printf("%d, %d",x,y);
	return 0;
}
