#include<stdio.h>
int main()
{ int n=7, m=6; /*khai bao hai gia tri m va n*/
  int*pn = &n; /*gan gia tri cua n vao con tro pn*/
  int*pm = &m; /*gan gia tri cua m vao con tro pm*/
  *pn = *pm + 2*m - 3*n; /*pn = -3 => gan gia tri moi cho con tro => n=-3*/
  *pm -= *pn; /*pm = 0 => gan gia tri moi cho con tro => m=9*/
  printf("%d", m+n); /*In ra ket qua m + n = 6*/ 
  getchar();
  return 0;
}
