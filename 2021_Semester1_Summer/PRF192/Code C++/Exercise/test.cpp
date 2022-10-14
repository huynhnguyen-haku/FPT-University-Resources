#include<stdio.h>
#include <conio.h>
void nhap(int a[], int n) 
{
    for (int i = 1; i < n; i++)
    {
        printf("Please enter prime number [%d]: ", i);
        scanf("%d", &a[i]);
    }
} 
//Phuong trinh kiem tra
int prime(int a[])
{
	int i, checkprime = 0;
  	printf("Enter a positive integer: ");
  	scanf("%d", &a[i]);

  for (i = 2; i <= a[i]/ 2; ++i) {
    if (a[i] % i == 0) {
      checkprime = 1;
      break;
    }
  }

  if (a[i] == 1) {
    printf("1 is neither prime nor composite");
  } 
  else {
    if (checkprime == 0)
      printf("%d is a prime number", a[i]);
    else
      printf("%d is not a prime number", a[i]);
  }
  return 0;
}
