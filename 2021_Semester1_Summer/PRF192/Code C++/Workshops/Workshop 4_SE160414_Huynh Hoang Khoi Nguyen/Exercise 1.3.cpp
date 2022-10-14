#include<stdio.h>
int main()
{ double x = 3.2, y = 5.1;  /*khai bao hai gia tri x va y*/
  double*p1 = &x; /*gan gia tri cua x vao con tro p1*/
  double*p2 = &y; /*gan gia tri cua y vao con tro p2*/
  *p1 += 3-2*(*p2); /*p1 = -4 => gan gia tri moi cho con tro => x=-4*/
  *p2 -= 3*(*p1); /*p2 = 17.1 => gan gia tri moi cho con tro => y=17.1*/
  printf("%lf", x+y); /*In ra ket qua x + y = 13.1*/ 
  getchar();
  return 0;
}
