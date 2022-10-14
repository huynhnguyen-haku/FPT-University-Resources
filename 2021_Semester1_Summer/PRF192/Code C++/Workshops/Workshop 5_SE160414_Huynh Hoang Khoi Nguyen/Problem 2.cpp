/*A basket contains ten balls. 
Balls are numbered from 1 to 10.
User gets a pair of balls and he/she hopes that sum of numbers is equal to a known expected total
*/

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
	printf("Ball Lottery\n");
	printf("============\n");
	printf("Total sought:\n");
	scanf("%d",&total);
	while (total<2 || total >20);
	do
	{
		x = intRandom(2,10);
		y = intRandom(2,10);
		count +=2;
	    printf("Result of throw %d and %d: %d + %d \n", count-1, count, x, y);
	}
	while (x + y != total);
	printf("You got your total in %d picks!", count);
}
 
