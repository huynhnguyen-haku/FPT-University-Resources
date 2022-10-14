#include <stdio.h>
#include <stdlib.h>
#include <math.h> 
int isPrime(int n);
int main()
{ int n;
  int check;
  do
   {printf("Nhap 1 so nguyen, ket thuc bang 0:");
    scanf("%d", &n);
    check = isPrime(n);
       if(check==1) printf("%d la so nguyen to\n",n);
	   else printf("%d khong la so nguyen to\n",n);
	}
while (n!=0);
system("pause");
return 0;
}

