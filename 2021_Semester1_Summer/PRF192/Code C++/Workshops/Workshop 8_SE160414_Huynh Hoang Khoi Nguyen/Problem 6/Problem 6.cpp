//Para_Arr_demo.c
#include <stdio.h>
#include <string.h>

//Read data i n a file to 3 array
void readFile(char* fname, char names[][41], char adds[][41], int* marks, int* pn);

//Sort the list based on marj descendingly
void sort(char names[][41], char adds[][41], int* marks, int n);

//Print out the list to monitor
void print(char names[][41], char adds[][41], int* marks, int n);

//Write the list to file
void writeFile(char* fname, char names[ ][41], char adds[][41], int* marks, int n);
 int main()
 {
 	char inFilename[] = "students.txt";
 	char outFilename[] = "students_2.txt";
 	//3 arrays represent a list of students
	 char names[50][41];
	 char adds[50][41];
	 int marks[50];
	 int n = 0; //Number of students
	 
	 //Read data from file to arrays
	 readFile(inFilename, names, adds, marks, &n);
	 
	 //Sort the list based on mark descendingly
	 sort(names, adds, marks, n);
	 
	 //Print out result
	 printf("Sorted List:\n");
	 print(names, adds, marks, n);
	 
	 //Write the list to file
	 writeFile(outFilename, names, adds, marks, n);
	 printf("Result file:%s\n", outFilename);
	 getchar();
	 return 0; 
} 
// Read data in a file to 3 arrays
void readFile(char* fname, char names[][41], char adds[][41], int* marks, int *pn)
{
	*pn = 0; //Reset number of elements
	FILE* f = fopen(fname, "r");
	if (f!=NULL)
	{
		//While read successfully a whole data line
	    while (fscanf( f, "%40[^;]; %40[^;]; %d%*c", names[*pn], adds[*pn], &marks[*pn])==3)
	    (*pn)++;
	    fclose(f);
	 } 
}

//Print out the list to moniter
void print(char names[][41], char adds[][41], int* marks, int n)
{
	int i;
	for (i = 0; i < n; i++)
	printf("%-20s%-41s%4d\n", names[i], adds[i], marks[i]);
}

//sort the list based on mark descendingly - Bubble sort
void sort(char names[ ][41], char adds[][41], int* marks, int n)
{
	int i, j;
	for (i = 0; i < n-1; i++)
	     for ( j = n -1; j > i; j--)
		     if (marks[j] > marks[j - 1])
			 {
			 	//Swap array name
			 	char tName[41];
			 	strcpy(tName, names[j]);
			 	strcpy(names[j], names[j - 1]);
			 	strcpy(names[j - 1], tName);
			 	
			 	//Swap array addss
			 	char tAdd[41];
				strcpy(tAdd, adds[j]);
				strcpy(adds[j], adds[j - 1]);
				strcpy(adds[j - 1], tAdd); 
				
				//Swap array marks
				int tMark = marks[j];
				marks[j] = marks[j - 1];
				marks[j - 1] = tMark;
			   }  
}
//Write the list to file
void writeFile(char* fname, char names[ ][41], char adds[][41], int* marks, int n)
{
	FILE* f = fopen(fname,"w");
	int i;
	for (i = 0; i < n; i++)
	     fprintf(f, "%s;%s;%d\n", names[i], adds[i], marks[i]);
	fclose(f);
}
