#include<stdio.h>
#include<stdlib.h>
int MAX = 20;
int main()
{ int a1[5];
  double *a2=NULL;
  printf("MAX addr:= %u\n", &MAX);
  printf("main() addr:= %u\n", &main);
  /*allocate a mem. block for 10 double numbers*/
  a2 = (double*)calloc(10, sizeof(double));
  printf("a2 addr:= %u\n", &a2);
  printf("a1:= %u, a2= %u\n", a1, a2);
  getchar();
  return 0;
}
