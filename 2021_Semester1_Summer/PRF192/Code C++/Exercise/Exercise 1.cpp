#include <stdio.h>
#include <conio.h>
void nhap(int a[], int n)
{
    for (int i = 0; i < n; i++)
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
    int a[9];
    int cmax=0, cmin=0, i; 
    int n=10;  
    nhap(a, n);
    for (i=0; i<n; i++)
	{	if(a[i]==max(a,n))	cmax++; 
		if(a[i]==min(a,n))	cmin++; 
	}
    printf("\nMax = %d, The times appered: %d", max(a, n), cmax);
    printf("\nMin = %d, The times appered: %d", min(a, n), cmin);
    return 0;
}
