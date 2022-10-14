//Develop a C-program that helps user managing an 1-D array of real number (maximum 100 elements), with initial number of elements is 0
#include<stdio.h>
#include<stdlib.h>
#define MAXN 100
//Get user choice
int menu ()
{
	printf("-------Menu-------");
	printf("\nOne-Dimensional Array of Integers");
	printf("\n1 - Add a value");
	printf("\n2 - Search a value");
	printf("\n3 - Print out the array");
	printf("\n4 - Print out values in a range");
	printf("\n5 - Print out the array in ascending order");
	printf("\nSelect:");
	int choice;
	scanf("%d", &choice);
	return choice;
}
//Testing whether an array is full or not
int isFull (int*a, int n)
{
	return n == MAXN;
}
//Testing whether an array is emty or not
int isEmpty (int*a, int n)
{
	return n == 0;
}
//Case 1: Add a value
void add(int value, int*a, int*pn)
{
	a[*pn] = value; //Add it to the end of the array
	(*pn)++;
}
//Case 2: Search a value
int search(int x, int*a, int n)
{
	int i;
	for (i = 0; i < n; i++)
	if  (a[i] == x) return i;
	return -1;
}
//Case 3: Print out the array
void print(int*a, int n)
{
	int i;
	for (i=0; i<n; i++) printf("%d", a[i]);
}
//Case 4: Print out the array in a range
void printvalueinrange(int*a, int n)
{   int i, min, max;
    printf("Enter minimum value:");
    scanf("%d", &min);
    printf("Enter maximum value:");
    scanf("%d", &max);
    for(i=0; i<=sizeof(a); i++)
    if(a[i]>=min&&a[i]<=max) printf("%d,", a[i]);
}
//Case 5: Print out the array in ascending order
void printAsc(int*a, int n)
{//Get addresses of elements
	int**adds = (int**)calloc(n, sizeof(int*));
	int i, j;
	for (i = 0; i < n; i ++)
	     adds[i] = &a[i];	     
    //Asc Sort addresses based on values of elements
int*t;
for (i = 0; i < n-1; i++)
     for (j = n - 1; j > i; j--)
	     if (*adds[j] < *adds[j - 1]) 
	     {
	     	t=adds[j];
			adds[j]=adds[j-1];
			adds[j-1]=t;
			 
		 }
	//Print Elements based on it's pointer
     for (i=0; i<n; i++)
	     printf("%d", adds[i]);
	free(adds); //de-allocate memory 
}
int main()
{
	int a[MAXN];
	int n=0;
	int value;
	int userChoice;
	do
	{
		userChoice = menu();
		switch(userChoice)
		{
			case 1:
				if (isFull(a,n)) printf("\nSorry! The array is full.\n");
				else
				{
					printf("Input the value:");
					scanf("%d",&value);
					add(value, a, &n);
					printf("Added\n"); 
				}
				break;
			case 2:
				if (isEmpty(a,n)) printf("\nSorry! The array is empty.\n");
				else
				{
					printf("Intput the searched value:");
					scanf("%d", &value);
					int pos = search(value, a, n);
					if (pos <0) printf("Not found\n");
					else printf("Position is found:%d\n", pos);
				}
				break;
			case 3:
				print(a,n);
				break;
			case 4:
                printvalueinrange(a,n);
				break;
			case 5:
				printAsc(a,n);
				break;

			default: printf("\nGoodbye.\n");
		}
	}
	while (userChoice>0 && userChoice<8);
	getchar();
	return 0;
}
