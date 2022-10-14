/* A program that will throw two dice until the top faces of the two dice total to a specified number */
#include<stdio.h>
#include<stdlib.h>
#include<math.h>
#include <time.h>
//Get a random integer between min and max randomly
int intRandom(int min, int max)
{
	int total;
	total = min + rand()%(max-min+1);
	return total;
} 
main()
{
	srand(time(NULL));
	int x, y, count, total;
	printf("Dice Thrower\n");
	printf("============\n");
	printf("Total sought:\n");
	scanf("%d",&total);
	while (total<2 || total >12);
	count = 0;
	do
	{
		x = intRandom(1,6);
		y = intRandom(1,6);
	    printf("Result of throw %d : %d + %d \n", ++count, x, y);
	}
	while (x + y != total);
	printf("You got your total in %d throws!", count);
}
 
