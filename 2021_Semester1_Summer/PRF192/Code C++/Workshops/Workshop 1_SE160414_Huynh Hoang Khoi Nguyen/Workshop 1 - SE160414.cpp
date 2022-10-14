#include<stdio.h>
int n;
double x;
char c1;
int main()
{   int m;
	short s;
	long L;
	float y;
	    printf("Code of main:%u\n", &main);
        printf("Variable n, add:%u, Memory zise %d\n", &n, sizeof(n));
    	printf("Variable x, add:%u, Memory zise %d\n", &x, sizeof(x));
	    printf("Variable c1, add:%u, Memory zise %d\n", &c1, sizeof(c1));
	    printf("Variable m, add:%u, Memory zise %d\n", &m, sizeof(m));
    	printf("Variable s, add:%u, Memory zise %d\n", &s, sizeof(s));
    	printf("Variable L, add:%u, Memory zise %d\n", &L, sizeof(L));
    	printf("Variable y, add:%u, Memory zise %d\n", &y, sizeof(y));
	getchar();  /*complete the program, compile and run it*/
return 0; /*Draw the memory  of the program*/
}

