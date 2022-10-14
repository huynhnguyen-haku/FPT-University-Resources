#include<stdio.h>
int main ()
{ int mark;
  int reward;
  printf("Your mark:");
  scanf("%d",&mark);
  (mark>8)? printf("Reward:500000"):printf("Reward:0");
  getchar();getchar();
  return 0;
}
