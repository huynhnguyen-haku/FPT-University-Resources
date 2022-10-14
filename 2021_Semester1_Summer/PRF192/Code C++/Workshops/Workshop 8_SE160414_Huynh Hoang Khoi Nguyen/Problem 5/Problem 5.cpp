/* array_file_demo2.c */
#include <stdio.h>

/* Processing data in a file is slow. So, if possiblem all operations
should be prformed in one time */
void processFile(char * fname, int * pCount, double * pSum)
{
	FILE * f = fopen(fname, "r");
	*pCount = 0; /* Reset count */
	*pSum = 0; /* Reset sum */
	double x; /* Variable containing a value from file */ 
	while (fscanf(f, "%lf", &x) == 1)
	{
		(*pCount)++;
		(*pSum) += x;
	}
	fclose(f);
}

int main()
{
	char infName[] = "array3.txt";
	int count = 0; //Number of values in file
	double sum = 0; //Sun of values in file
	processFile(infName, &count, &sum);
	printf("Number of values in the file : %d\n", count);
	if (count == 0)
	     printf("Average of values in the file : 0\n");
	else printf("Average of values in the file : %lf\n", sum/count);
	getchar();
	return 0;
}
