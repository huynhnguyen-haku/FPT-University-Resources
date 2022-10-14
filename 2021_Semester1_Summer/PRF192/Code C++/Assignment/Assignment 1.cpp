/* Managing an 1-D array of integers */ 
#include <stdio.h>
#include <stdlib.h>
#define MAXN 100

int getUserChoice() {
	int Choice;
	printf("One-Dimensional Array of Integer:\n");
	printf("1- Add value\n");
	printf("2- Search a value\n");
	printf("3- Remove the first existence of a value\n");
	printf("4- Remove all the existence of a value\n");
	printf("5- Print out the array\n");
	printf("6- Print out the array in ascending order\n");
	printf("7- Print out the array in descending order\n");
	printf("Other- Quit\n");
	printf("Select:\n");
	scanf("%d", &Choice);
	system("cls");
	return Choice;
}

//Testing whether an array is full or not 
int isFull(int* a, int n)
{
	return n == MAXN;
}

//Testing whether an array is empty or not
int isEmpty(int* a, int n)
{
	return n == 0;
}

//Adding an element to the end of the array
void add(int x, int*a, int*pn)
{
	a[*pn] = x;
	(*pn)++;
} 

//Searching an element and pointing out its position
int Search(int x, int* a, int n)
{
	int i;
	for (i = 0; i < n; i++)
	{
		if (a[i] == x) return i;
	}
	return -1;
}

//Removing an element at the position of an array
//Return 0: remove fail ; Return 1: remove successfully
int removeOne(int pos, int* a, int* pn)
{
	if (pos < 0 || pos >(*pn)) return 0;
	int i;
	for (i = pos; i < (*pn - 1); i++)
	{
		a[i] = a[i + 1];
	}
	(*pn)--;
	return 1;
}
//Removing same inputted element of an array
int removeAll(int x, int* a, int* pn)
{
	int result = 0;
	int i, j;
	for (i = (*pn - 1); i >= 0; i--)
		if (a[i] == x)
		{
			result = 1;
			for (j = i; j < (*pn - 1); j++) a[j] = a[j + 1];
			(*pn)--;
		}
	return result; 
}

//Printing out the array
void PrintArray(int* a, int n) {
	int i;
	printf("The elements of Array:\n");
	for (i = 0; i < n; i++)
	{
		printf("%d ", a[i]);
	}
	printf("\n");
}

//Printing out the array in ascending order
void PrintAsc(int* a, int n)
{
	
	int i, j; 
	int t;
	for (i = 0; i < n-1 ; i++)
		for (j = n - 1; j > i; j--)
			if (a[j] < a[j - 1])
			{
				t = a[j];
				a[j] = a[j - 1];
				a[j - 1] = t; 
			}
	for (i = 0; i < n; i++) printf("%d ", a[i]);
}

//Print out the array in descending order
void PrintDesc(int* a, int n)
{
	int i, j;
	int t;
	for (i = 0; i < n - 1; i++)
		for (j = n - 1; j > i; j--)
			if (a[j] > a[j - 1])
			{
				t = a[j];
				a[j] = a[j - 1];
				a[j - 1] = t;
			}
	for (i = 0; i < n; i++) printf("%d ", a[i]);
}

int main() {
	int userChoice;
	int a[MAXN];
	int n = 0;
	int value; 
	do {
		userChoice = getUserChoice();
		switch (userChoice)
		{
		case 1:
		{
			if (isFull(a, n)) printf("Sorry! The array is full.\n");
			else
			{
				int i,number;
				printf("How many number do you want to insert into array: ");
				scanf("%d", &number);
				for (i = 0; i < number; i++)
				{
					printf("Input No.%d value: ", n+1);
					scanf("%d", &value);
					add(value, a, &n);
					printf("Added!\n");	
				}
			}
			break;
		}
		case 2:
		{
			if (isEmpty(a, n)) printf("Sorry! The array is empty.\n");
			else
			{
				printf("Input the number you want to search:");
				scanf("%d", &value);
				int pos = Search(value, a, n);
				if (pos < 0) printf("Number not found!\n");
				else printf("Position is found: %d\n", pos + 1);
			}
			break;
		}
		case 3:
		{
			if (isEmpty(a, n)) printf("Sorry! The array is empty.\n");
			else
			{
				printf("Input the number you want to remove: ");
				scanf("%d", &value);
				int pos = Search(value, a, n);
				if (pos < 0) printf("Not found!\n");
				else
				{
					removeOne(pos, a, &n);
					printf("Removed!\n");
				}
			}
			break;
		}
		case 4:
		{
			printf("Input the the number you want to remove all of its existences: ");
			scanf("%d", &value);
			int pos = Search(value, a, n);
			if (pos < 0) printf("Not found!\n");
			else
			{
				removeAll(value, a, &n);
				printf("Removed!\n");
				
			}
			break;
		}
		case 5:
		{
			PrintArray(a, n);
			break;
		}
		case 6: 
		{
			PrintAsc(a,n);
			break;
		}
		case 7:
		{
			PrintDesc(a,n);
			break;
		}
		default:
		{
			printf("Good bye!\n");
			break;
		}
		}
	} while (userChoice > 0 && userChoice < 8);
	getchar();
	return 0;
}
