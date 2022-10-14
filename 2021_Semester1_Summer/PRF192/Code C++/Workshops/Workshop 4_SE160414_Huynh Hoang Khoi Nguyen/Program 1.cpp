/* Write a C program that will execute repetitively using a simple menu as following: 

1-	Process primes
2-	Print min, max digit in an integer;
3-	Quit
Select an operation:
*/

#include <stdio.h>
/*Check Prime*/
int Prime(int n)
{
	int i, checkprime = 0;
  	printf("Enter a positive integer: ");
  	scanf("%d", &n);

  for (i = 2; i <= n / 2; ++i) {
    if (n % i == 0) {
      checkprime = 1;
      break;
    }
  }

  if (n == 1) {
    printf("1 is neither prime nor composite");
  } 
  else {
    if (checkprime == 0)
      printf("%d is a prime number", n);
    else
      printf("%d is not a prime number", n);
  }
  return 0;
}
/*Check max, min digit of number*/
int MaxMinDigit(int n)
{		
	printf("Enter a positive number: ");
	scanf("%d", &n);
	int min=n%10, max=n%10;
	n/=10;
	while (n>0)
	{
		if (min>n%10) min=n%10;
		else if (max<n%10) max=n%10;
		n/=10;
	}
	printf("Max digit in this number is:%d\n",max);
	printf("Min digit in this number is:%d\n",min);
}

void function1()
{	int n; 
	Prime(n);
}

void function2()
{	int n; 
	MaxMinDigit(n);
}

int getchoice()
{
	int choice;
	printf("\n-----CHOOSE AN OPTION-----");
	printf("\n1 - Process primes");
	printf("\n2 - Print min, max digit in an integer");
	printf("\n3 - Quit The Program\n");
	do
	{
	printf("Your option: ");
	scanf("%d%*c",&choice);
	if (choice>3 || choice<1) printf("Invalid option!, please try again!\n");
	} while (choice>3 || choice<1);
	return choice;
}

int main()
{
	int userchoice;
	do
	{
	userchoice=getchoice();
	switch (userchoice)
		{
		case 1: function1(); break;
		case 2: function2(); break;
		case 3: 
		printf("Good bye!");
		return 0; break; 	
		}
	} while (userchoice<=3 && userchoice>=1);
	fflush(stdin);
	getchar();
	return 0;
}
