#include<stdio.h>
int main()
{ char c1 = 'A', c2 = 'F';  /*khai bao hai gia tri A va F*/
  char*p1 = &c1; /*gan gia tri cua A vao con tro p1*/
  char*p2 = &c2; /*gan gia tri cua F vao con tro p2*/
  *p1+= 3; /*p1 = 68 => gan gia tri moi cho con tro => c1=D*/
  *p2 -= 5; /*p2 = 65 => gan gia tri moi cho con tro => c2=A*/
  printf("%d", c1-c2); /*In ra ket qua c1 - c2 = 3*/ 
  getchar();
  return 0;
}
