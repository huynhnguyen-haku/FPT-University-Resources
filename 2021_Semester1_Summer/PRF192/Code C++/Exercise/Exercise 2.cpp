#include <stdio.h>
#include <math.h>
bool IsPrime(int n)
{
    if (n < 2)
        return false;
    for (int i = 2; i <= sqrt(n); i++)
    {
        if (n % i == 0)
        {
            return false;
        }
    }
    return true;
}
int main ()
{	int a[5],i=0; int n=5;
	do
	{
		printf("Enter prime number a[%d]: ", i+1);
		scanf("%d",&a[i]);
		if (IsPrime(a[i])==true) i++;
		else {	printf("That is not prime number, try again\n");
				printf("\n");
		}
	} while (i<n);
	for (i=0; i<n; i++) printf("%d ", a[i]);
	return 0;
 }
