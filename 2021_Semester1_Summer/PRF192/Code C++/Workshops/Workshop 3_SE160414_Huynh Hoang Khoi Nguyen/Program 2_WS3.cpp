/*Nhap vao ngay thang xong cho biet chung co hop le hay khong*/
#include <stdio.h>
int validDay(int d, int m, int y)
{ int maxd=31; /*So ngay cua nhung thang 1, 3, 5, 7, 8, 10, 12*/
   if (d<1 || d>31 || m<1 || m>12) /*Cap nhat so ngay toi da cua mot thang*/
     return 0;
   if (m==4 || m==6 || m==9 || m==11)
     maxd=30; 
   else if (m==2) /*Nam nhuan*/
   if ( y%400==0 || ( y%4==0 && y%100!=0))
     maxd=29;
   else maxd=28;
   return d<=maxd;
}
int main()
{ int d,m,y;
  printf("Please enter date:");
  scanf("%d%d%d",&d,&m,&y);
  while (d<1 || d>31 || m<1 || m>12)
{
   printf("Please enter number of day in [1,31], number of month in [1,12]: ");
   scanf("%d%d%d",&d,&m,&y);
}
if (validDay(d,m,y))
printf("Valid day.");
else printf("Invalid day.");
return 0;
}


