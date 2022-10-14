/*file pointer_demo 7*/
#include<stdio.h>
/*swap 2 integers at pointers*/
void swap2 (int* px, int* py)
{ int t = *px; /*t = value at px*/ 
  *px = *py; /*value at px = value at py*/
  *py = t; /*value at py = t*/
}
int main ()
{ int a=5, b=7;
  printf("a=%d, b=%d\n", a, b);
  swap2 ( &a, &b);
  printf("a=%d, b=%d\n", a, b);
  getchar();
  return 0;
}
