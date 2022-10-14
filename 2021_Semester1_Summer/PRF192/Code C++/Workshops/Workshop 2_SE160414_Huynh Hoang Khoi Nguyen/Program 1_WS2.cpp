/*Basic operations between two integers*/
#include <stdio.h>
main()
{
	double num1, num2, result;
	char op;
	printf("Enter an expression (+ - * /): "); 
	scanf("%lf%c%lf", &num1, &op,&num2); /*Input values*/
	switch (op)
	{
		case '+':
			 	result = num1 + num2;
			 	printf("Result: %3lf", result);
			break;
		case '-':
			 	result = num1 - num2;
			 	printf("Result: %3lf", result);
			break;
		case '*':
			 	result = num1 * num2;
			 	printf("Result: %3lf", result);
			break;
		case '/':
			 	result = num1 / num2;
			 	printf("Result: %3lf", result);
			break;
		default:
			printf("Op is not supported");
	}
}

