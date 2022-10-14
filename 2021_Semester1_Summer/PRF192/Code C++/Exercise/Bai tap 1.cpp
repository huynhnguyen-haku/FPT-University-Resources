#include <stdio.h>
#include <conio.h>
void nhap(int a[], int n)
{
    for (int i = 1; i < n; i++)
    {
        printf("Nhap vao phan tu a[%d]: ", i);
        scanf("%d", &a[i]);
    }
}
//Gia tri lon nhat
int max(int a[], int n)
{
    int max = a[0];
    for (int i = 1; i < n; i++)
        if (max < a[i])
            max = a[i];
    return max;
}
//Gia tri nho nhat
int min(int a[], int n)
{
    int min = a[0];
    for (int i = 1; i < n; i++)
        if (min > a[i])
            min = a[i];
    return min;
}
//setup
int main()
{
    int a[10];
    int n = 11;
    nhap(a, n);
    printf("\nMax = %d", max(a, n));
    printf("\nMin = %d", min(a, n));
    return 0;
}

