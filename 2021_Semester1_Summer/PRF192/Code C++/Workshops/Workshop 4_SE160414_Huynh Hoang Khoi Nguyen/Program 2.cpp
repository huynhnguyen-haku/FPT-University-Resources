/* Write a C program that will execute repetitively using a simple menu as following: 

1-Fibonacci sequence
2-Check a date
3-Quit
Choose an operation:
*/

#include <stdio.h>
/*Fibonacci sequence*/
 void function1()
{
  int n;
  int t1=1, t2=1, f=1;
  int i;
  printf("Xin hay nhap gia tri n:");
  scanf("%d",&n);
  for (i=1; i<=n;i++)
  {
  if (i<3) printf("%d,",f);
  else
     {
	  f=t1+t2;
      printf("%d,",f);
      t1=t2;
      t2=f;
  }
  }
}
/*Check a date*/
int validDay(int d, int m, int y)
{
   int maxd=31; /*So ngay cua nhung thang 1, 3, 5, 7, 8, 10, 12*/
   if (d<1 || d>31 || m<1 || m>12) /*Cap nhat so ngay toi da cua mot thang*/
     return 0;
   if (m==4 || m==6 || m==9 || m==11)
     maxd=30; 
   else if (m==2) /*Nam nhuan*/
   if ( y%400==0 || ( y%4==0 && y%100!=0))
     maxd=29;
   else maxd=28;
   return d<=maxd;
}
void function2()
{ 
  int d,m,y;
  printf("Please enter date:");
  scanf("%d%d%d",&d,&m,&y);
  while (d<1 || d>31 || m<1 || m>12)
{
   printf("Please enter number of day in [1,31], number of month in [1,12]: ");
   scanf("%d%d%d",&d,&m,&y);
}
if (validDay(d,m,y))
printf("Valid day.");
else printf("Invalid day.");
}
/*Menu setup*/  
int getchoice()
{
	int choice;
	printf("\n-----CHOOSE AN OPTION-----");
	printf("\n1 - Fibonacci sequence");
	printf("\n2 - Check a date");
	printf("\n3 - Quit The Program\n");
	do
	{
	printf("Your option: ");
	scanf("%d%*c",&choice);
	if (choice>3 || choice<1) printf("Invalid option!, please try again!\n");
	}
	while (choice>3 || choice<1);
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
