#include <stdio.h>
int main()
{ int n=30, m=7;
printf("%d,%d\n", n/m, n%m);
int t = ++m;
printf("Prefix increasing operator: t=%d, m=%d\n", t, m);
int k= m++;
printf("Postfix increasing operator: k=%d, m=%d\n", k, m);
getchar();
return 0;
}
