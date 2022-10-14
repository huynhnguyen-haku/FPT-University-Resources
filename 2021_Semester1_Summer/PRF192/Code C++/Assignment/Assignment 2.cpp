/*Static Matric Demo.*/
#include<stdio.h>
#define MAXR 20
#define MAXC 20
/*Input a mtrix of ints, num of rows and column are known*/
void input (int m[][MAXC], int r, int c );
int max (int m[][MAXC], int r, int c);
void print (int m[][MAXC], int r, int c);
int main()
{
	int m[MAXR][MAXC]; //Declare a static matrix
	int r, c; //Real used number of rows and columns
	int maxVal;
	do
	{
		printf("Enter number of rows and columns of the matrix:");
		scanf("%d%d", &r, &c); 
	}
	while (r<1 || r>MAXR || c<1 || c>MAXC); 
	printf("Enter a matrix %d x %d\n", r, c);
	input(m, r, c);
	maxVal = max (m, r, c);
	printf("Max value:%d\n", maxVal);
	printf("\nInputted matrix:\n");
	print(m, r, c);
	while (getchar()!='\n'); getchar();
	return 0; 
}
void input(int m[][MAXC], int r, int c)
{
	int i, j;
	for (i=0; i<r; i++) //Enter values to each row
	{
		for (j=0; j<c; j++) //Enter value to each column
		{
			printf("Value at [%d][%d]:", i, j);
			scanf("%d", &m[i][j]);
		 } 
	}
}
int max(int m[][MAXC], int r, int c)
{
	int result = m[0][0];
	int i, j;
	     for (i=0; i<r; i++)
	         for (j=0; j<c; j++)
	             if (result < m[i][j]) result = m[i][j];
	return result; 
 } 
 void print (int m[][MAXC], int r, int c) 
 {
 	int i, j;
 	for (i=0; i<r; i++)
 	{
 		for (j=0; j<c; j++) printf("%7d", m[i][j]);
 		printf("\n");
	 }
 }
