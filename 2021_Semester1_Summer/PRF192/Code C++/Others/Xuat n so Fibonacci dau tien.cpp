/*Xuat n so Fibonacci dau tien*/
#include <stdio.h>
#include <stdlib.h>
int main ()
{ int n;
  int t1=1, t2=1, f=1;
  int i;
  printf("Xin hay nhap gia tri n:");
  scanf("%d",&n);
  for (i=1; i<=n;i++)
  {if (i<3) printf("%d,",f);
  else
     {f=t1+t2;
      printf("%d,",f);
      t1=t2;
      t2=f;
  }
  }
  system("pause");
  return 0;
}
