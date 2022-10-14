#include <stdio.h>
#include<stdlib.h> 
int getInt(int min, int max)
{
	int value, keeptrying = 1, rc;
	char after;
	do
	{
		printf("Enter a whole number\n"
		       "In the range [%d,%d]: ", min, max);
	    rc = scanf("%d%c", &value, &after);
		if (rc == 0)
		{
			printf("**No input accepted!**\n\n");
			clear(); 
		}
		else if (after != '\n')
		{
			printf("**Trauling characters!**\n\n");
			clear();
		} 
		else if (value < min || value > max)
		{
			printf("**Out of range!**\n\n"); 
		}
		else
		keeptrying = 0;
	}
	while (keeptrying == 1);
	return value;
 } 
