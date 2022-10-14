/*Values swapping*/ 
#include<stdio.h>
int main ()
{ int x,y;
  printf("Please enter the values of x and y:");
  do
  { scanf("%d", &x);
    scanf("%d", &y);
    int t = x;
        x = y;
	    y = t;
  printf("The values of x and y after swapping: x = %d, y = %d", x, y);
  }
 while (x!=0, y!=0);
 } 
