//Array_Sample01.c
#include<stdio.h>
#include<stdlib.h>
#define MAXN 100
//Get user choice
int menu ()
{
	printf("\nOne-Dimensional Array of Integers");
	printf("\n1 - Add a value");
	printf("\n2 - Search a value");
	printf("\n3 - Remove the first existence of a value");
	printf("\n4 - Remove all the existence of a value");
	printf("\n5 - Print out the array");
	printf("\n6 - Print out the array in ascending order");
	printf("\n7 - Print out the array in descending order");
	printf("\nOthers - Quit");
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
//Adding an element to the end of array will increase number of elements
void add(int value, int*a, int*pn)
{
	a[*pn] = value; //Add it to the end of the array
	(*pn)++;
}
//Find the first existence of x in the array - Linear Searching
int search(int x, int*a, int n)
{
	int i;
	for (i = 0; i < n; i++)
	if  (a[i] == x) return i;
	return -1;
}
//Removing the element at a position in an array will decrease number of elements return 1: remove successfully, 0: remove fail
int removeOne (int pos, int*a, int*pn)
{
	if (pos < 0 || pos >= *pn) return 0;
	int i;
	for (i = pos; i < *pn-1; i++)
	     a[i] = a[i+1];
	(*pn)--; //Decrease number of elements
	return 1; //Successfully
}
//Removing all existence of a value from the array. Return 1: success, 0: fail
int removeAll (int x, int*a, int*pn)
{
	int result = 0;
	//Remove from the end of the array. So, no value is missed
	int i, j;
	for (i=(*pn)-1; i >= 0; i--)
	     if (a[i] == x)
	     //Shift up all elements after the position i
	     {
	     	result = 1;
	     	for (j = i; j < (*pn)-1; j++)
	     	a[j] = a[j + 1];
	     	(*pn)--;
		 }
	return result;
}
//Print the array in ascending order, positions of elements are preserved
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
    //Print the array in descending order, positions of elements are preserved
void printDesc(int*a, int n)
{   //Get addresses of elements
  	int**adds = (int**) calloc (n, sizeof (int*));
 	int i, j;
 	for (i=0; i<n; i++) adds[i]=&a[i];
    //Desc Sort addresses basad of value of elements
     int*t;
     for (i=0; i<n-1; i++)
         for (j=n=1; j>i; j--)
             if (*adds[j] > *adds[j-1])
             {
             	 t = adds[j];
				 adds[j] = adds[j-1];
				 adds[j-1] = t;   
			 }
	//Print elements based of it's pointer
	for (i=0; i<n; i++) printf("%d", *adds[i]);
	free(adds); //de-allocatye memory
}
//Print elements of the arrays
void print(int*a, int n)
{
	int i;
	for (i=0; i<n; i++) printf("%d", a[i]);
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
				if (isEmpty(a,n)) printf("\nSorry! The array is empty.\n");
				else
				{
					printf("Input the removed value:");
					scanf("%d",&value);
					int pos = search(value, a, n);
					if (pos<0) printf("Not found\n");
					else 
					{
						removeOne(pos, a, &n);
						printf("Removed!\n");
					}
				}
				break;
			case 4:
				if (isEmpty(a,n)) printf("\nSorry! The array is empty.\n");
				else
				{
					printf("Input a value that will be remove all:");
					scanf("%d", &value);
					if (removeAll(value, a, &n)==0) printf("Not found!\n");
					else printf("Removed!\n");
				}
				break;
			case 5:
				print(a,n);
				break;
			case 6:
				printAsc(a,n);
				break;
			case 7:
				printDesc(a,n);
				break;
			default: printf("\nGoodbye.\n");
		}
	}
	while (userChoice>0 && userChoice<8);
	getchar();
	return 0;
}
