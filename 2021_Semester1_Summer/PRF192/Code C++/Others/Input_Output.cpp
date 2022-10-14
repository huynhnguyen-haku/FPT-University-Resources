#include <stdio.h>
int main()
{ int n;
double x, y;
printf("Enter an integer:");
scanf("%d",&n);
printf("Enter 2 real numbers:");
scanf("%lf%lf", &x, &y);
double num1, num2;
char op;
printf("Enter an expression + - * / :");
scanf("%lf%lf", &num1, &op, &y);
printf("Expression inputted is: %lf%c%lf\n", num1, op, num2);
getchar();
getchar();
return 0;
} 
