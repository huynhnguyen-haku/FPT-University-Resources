#include <stdio.h>
int main () 
{ int mark;
  int reward;
  int noOfShirts;
  printf("Your mark:");
  scanf("%d",&mark);
  switch (mark)
  {
  	case 10: reward = 1000000;
  	         noOfShirts = 4;
  	         break;
    case 9: reward = 500000;
  	         noOfShirts = 3;
  	         break; 
    case 8: reward = 200000;
  	         noOfShirts = 2;
  	         break;
    case 7: reward = 100000;
  	         noOfShirts = 1;
  	default: reward = 0;
  	         noOfShirts = 0;
  	         break;	  	
  }
  printf("Reward:%d, Shirts:%d\n",reward, noOfShirts);
  getchar();getchar();
return 0;
}
