#include<stdio.h>
#include<math.h>
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


