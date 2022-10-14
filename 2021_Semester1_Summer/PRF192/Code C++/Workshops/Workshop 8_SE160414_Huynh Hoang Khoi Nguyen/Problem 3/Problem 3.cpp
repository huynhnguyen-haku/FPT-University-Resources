/* string_file_swmo1.c */
#include <stdio.h>
#include <string.h>
#include <ctype.h>

int exist(char * filename)
{
	int existed = 0;
	/*Try opening it for reading */
	FILE * f = fopen( filename, "r");
	if (f != NULL)
	{
		existed = 1;
		fclose(f);
	}
	return existed;
}

/* Write a file from line inputted until the 0-line entered */
int writeFile(char * filename)
{
	if (exist(filename)==1)
	{
		printf("The file %s existed. Override it Y/N?", filename);
		if (toupper(getchar()) == 'N') return 0;
	}
    char line[201]; /* inputted string */
    int length = 0; /* length if inputted line */
    /* open the file for writing */
    FILE * f = fopen(filename, "w");
	fflush(stdin); /* clear input buffer */
    do{
        gets(line); /* get a line - If user presses ENTER only --> length = 0 */
        length =  strlen(line);
        if (length > 0)
            fprintf(f,"%s\n",line); /* write \n to file */
    }
	while (length > 0);
    fclose(f);
    return 1;
}

/* Print out the content of a text file to the monitor */
int printFile(char * filename)
{
    if (exist(filename) == 0 )
    {
        printf("The file %s does not exist.\n", filename);
        return 0;
    }
    /* Open the file for reading */
    FILE * f = fopen(filename, "r");
    char line[201]; /* a line from the file */
    while (fscanf(f, "%[^\n]%*c", line) > 0) puts(line);
    fclose(f);
    return 1;
}

int main(int argCount, char * args[])
{
    char filename[81];
    printf("Program for writing and reading a file\n");
    printf("Enter a filename : ");
    gets(filename);
    printf("Write File : \n");
    if (writeFile(filename))
    {
        printf("Data in file %s : \n", filename);
        if ( !(printFile(filename)) ) printf("File error!\n");
    }
    else printf("Writing file %s fail!\n", filename);
    getchar ();
    return 0;
}
