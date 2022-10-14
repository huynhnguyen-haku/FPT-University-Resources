#include <stdio.h> 
void ascBubbleSort (int*a, int n)
{
	int i,j;//Vars for looping
	//Loop n-1 pass
	for (i = 0; i < n-1; i++)
	{//Go to the end of the array to move the min value up
		for (j = n -1; j > i; j--)
		//The later element is smaller than the previpud one
		if (a[j] < a[j-1])
		{//Move the smaller up
			int t = a[j];
			a[j] = a[j-1];
			a[j-1] = t;
		}
	}
}
void print(int*a, int n)
{
	int i;
	for (i = 0; i < n; i++)
	printf("%d", a[i] );
}
int main()
{
	int a[]={1,3,5,7,9,2,4,6,8,0};
	ascBubbleSort (a,10);
	print(a,10);
	getchar();
	return 0;
}
