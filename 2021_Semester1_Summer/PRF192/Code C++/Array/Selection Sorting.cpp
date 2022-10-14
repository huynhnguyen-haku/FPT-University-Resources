#include <stdio.h>
void ascSelectionSort (int*a, int n)
{
	int minIndex; //index of min. value in a group
	int i, j; //var for looping
	//Group begin at position i to n-1
	for (i = 0; i < n-1; i++)
	{
		minIndex = i; //init minium position
		//Update minIndex of the group at i, i+1,...,n-1
		for (j = i + 1; j < n; j++)
		//Move minium value to the begin of the group
		if (a[minIndex] > a[j])
		    minIndex = j;
		if (minIndex > i)
		{
			int t = a[minIndex];
			a[minIndex] = a[i];
			a[i] = t;
		}
	}
}
void print (int*a, int n)
{
	int i;
	for (i = 0; i < n; i++)
	printf("%d", a[i]); 
}
int main()
{
	int a[] = {1,3,5,7,9,2,4,6,8,0};
	ascSelectionSort(a, 10);
	print(a,10);
	getchar();
	return 0;
}

