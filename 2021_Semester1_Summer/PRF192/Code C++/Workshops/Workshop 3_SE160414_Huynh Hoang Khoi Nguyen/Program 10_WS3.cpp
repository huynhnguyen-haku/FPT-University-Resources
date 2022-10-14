/*In ra hai chu so lon nhat va nho nhat trong 1 phan tu*/
#include <stdio.h>
void printMinMaxDigits( int n)
{   int digit; /*Bien de trich xuat mot chu so*/
    int min, max ; /*Bien ket qua*/
    digit = n % 10; /*Lay chu so tan cung ben phai*/
    n = n / 10; /*Nhung so con lai tiep tuc sau*/
    min = max = digit; /*Khoi tao ket qua*/
    while (n > 0) /*Lay chu so tiep theo*/
   {
        digit = n % 10;
        n = n / 10;
        if (min > digit) min = digit; /*Cap nhat ket qua*/
        if (max < digit) max = digit;
   }
   printf("Max digit : %d\n", max);
   printf("Min digit : %d\n", min);
}

main()
{
    int n;
    do
	{ printf("Please enter a nonnegative integer:");
	  scanf("%d", &n);
      printMinMaxDigits(n);
    }
	while( n < 0);
	return 0;
}
