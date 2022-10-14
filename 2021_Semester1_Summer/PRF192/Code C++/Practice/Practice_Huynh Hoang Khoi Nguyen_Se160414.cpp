#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#define MAXN 100
#define FILENAM "D:/FPT University/Course/PRF192/Code C++/Huynh Hoang Khoi Nguyen SE160414/Chiko.txt"

int getUserChoice()
/*Function for getting choice from user - Menu*/
{
	int choice; 
	printf("\n--------Menu--------\n");
    printf("1-Enter a integer array\n");
    printf("2-Print out the array in descending order\n"); 
    printf("3-Add a new element to the array\n");
    printf("4-Print out the array in ascending order\n");
    printf("5-Save to file\n");
    printf("Others - Finish the program\n");
/*Accecpt user choice*/
    printf("Your choice:\n");
    scanf("%d", &choice);
    system("cls");
    return choice;
}
/*Testing whether an array is full or not*/ 
int isFull(int* a, int n)
{
	return n == MAXN;
}
/*Testing whether an array is empty or not*/
int isEmpty(int* a, int n)
{
	return n == 0;
}
/*Function for entering a integer array*/
void NhapMang(int a[], int n)
{
    for (int i = 0; i < n; i++)
	{
        printf("a[%d] = ", i+1);
        scanf("%d", &a[i]);
    }
}
/*Function to print out the array in descending order*/
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
	for (i = 0; i < n; i++) printf("%d\n", a[i]);
}

/*Function to print out the array in ascending order*/
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

/*Function for adding a new element to the array*/
void add(int x, int*a, int*pn)
{
	a[*pn] = x;
	(*pn)++;
}

/*Function for saving to file*/
void save(int a[], int n)
{
    FILE *file;
    /*Open file*/
    file = fopen("Chiko.txt","w");
    if (file = NULL)
	{
		printf("Can not open the file\n");
		return; 
	}  
    /*Save to file*/
    for(int i = 0; i < n; i++)
	{
		fprintf(file,"%3d",a[i]); 
	} 
    /*Close file*/
    fclose(file);
    printf("Save successfully\n"); 
}

int main()
{
	int userChoice;
	int a[MAXN];
	int n = 0;
	int value;
	do{
		userChoice = getUserChoice();
		switch(userChoice)
		{
			case 1:
					{
						printf("How many number you want to create for the array:");
						scanf("%d",&n);
						NhapMang(a, n);
					}
					break;
			case 2:
				{
					PrintDesc(a, n);
					break;
				}
			case 3:
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
		    case 4: 
	            {
	            	PrintAsc(a, n);
	            	break;
				}
			case 5:
				{
					save(a, n);
					break;
				}
			default:
				{
					printf("Good bye");
					break;
				}
		}
	}
while (userChoice > 0 && userChoice < 6);
getchar();
return 0;
}

