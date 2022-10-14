#include<stdio.h>
int main ()
{ int mark;
  int reward;
  printf("Your mark:");
  scanf("%d",&mark);
  reward = mark >8 ? 500000:0;
  printf("Reward:%d\n",reward);
  getchar();getchar();
  return 0;  
 } 
 
