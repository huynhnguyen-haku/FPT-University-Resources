/* array_file01.c */
#include <stdio.h>

/* read data in a fiel to array */
void fileToArray(char * filename, int * a, int * pn)
{
    FILE * f = fopen(filename, "r");
    /* Read the first number in the file --> number of elements */
    fscanf(f, "%d", pn);
    /* Read elements */
    int i;
    for ( i = 0; i < *pn; i++)
        fscanf(f, "%d", &a[i]);
    fclose(f);
}

void asc_sort(int * a, int n)
{
    int i, j, t;
    for ( i = 0; i < n -1; i++)
        for ( j = n - 1; j > i; j--)
            if (a[j] < a[j - 1])
            {
                t = a[j];
                a[j] = a[j - 1];
                a[j - 1] = t;
            }
}

/* Print out array to monitor */
int print(int * a, int n)
{
    int i;
    for (i = 0; i < n; i++) printf("%d ", a[i]);
    printf("\n");
}

/* Write array to file */
int printToFile(char * filename, int * a, int n)
{
	FILE * f = fopen(filename, "w");
	fprintf(f,"%d ", n); /* Write number of elements to file */
	int i;
	for ( i = 0; i < n; i++) /* Write elements to file */
		fprintf(f, "%d ", a[i]);
	fclose(f);
}

int main()
{
	char infName[]  = "array1.txt";
	char outfName[] = "array2.txt";
	int a[200];
	int n = 0;	
	fileToArray(infName, a, &n);
	asc_sort(a, n);
	/* Print array to monitor - stdout: monitor */
	print(a, n);
	/* Print array to file */
	printToFile(outfName, a, n);
	getchar();
	return 0;
}
