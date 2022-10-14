/*Chuong trinh tinh cac so le tu 0 den n*/
#include <stdio.h>
int main () {
	int n,i;
	printf("Xin hay nhap vao gia tri n:");
	scanf("%d",&n);

	int sum1=0;
	for (i=1; i <= n; i+=2) sum1+=i;
  printf ("\nsum1=%d", sum1);
  getchar(); getchar();
  return 0;
 } 

