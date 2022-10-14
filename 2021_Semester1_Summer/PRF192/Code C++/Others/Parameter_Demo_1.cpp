/*Array Parameters Demo*/
#include<stdio.h>
#define MAXN 100
/*Prototypes*/
void input(int*a, int n);
int max(int a[], int n);
void print (int*a, int n);
void printEven (int*a, int n);
int main()
{
	int a[MAXN];
	int n;
	int maxVal;
	do
	{
		printf("How many elements which will be used 1...%d:", MAXN);
		scanf("%d",&n);
	}
	while (n<1 || n>MAXN);
    printf("Enter %d values of the arrays:\n",n);
    input(a,n);
    maxVal = max (a,n);
    printf("Max value:%d\n", maxVal);
    printf("\nInputted array:");
    print(a,n);
    printf("\nEven values in array:");
    printEven(a,n);
    while (getchar()!='\n');
    getchar();
    return 0;
} 
void input(int*a, int n)
{
	int i;
	for (i=1; i<n; i++) scanf("%d", &a[i]); 
}
int max(int a[], int n)
{
	int result =a[0];
	int i;
	for (i=1; i<n; i++)
	    if (result<a[1]) result=a[i];
	    return result;
}
void input(int*a, int n)
{
	int i;
	for (i=0; i<n; i++) scanf("%d", a[i]); 
}
void printEven (int*a, int n);
int i;
for (i=0; i<n;i++)
if (a[i]%2 ==0 ) printf("%d", a[i]);
