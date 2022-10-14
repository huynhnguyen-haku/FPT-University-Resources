#include <stdio.h>
int main () {
	int mark;
	int reward;
	int noOfShirts;
	printf("Your mark:");
	scanf("%d",&mark);
	if (mark>7)
	{reward = 500000;
	 noOfShirts = 2;
    } 
	else
	{reward = 0;
	noOfShirts = 0;
	}
	printf("Reward:%d, shirts:%d\n", reward, noOfShirts);
	getchar(); getchar();
	return 0;
}
