/*Kiem tra vi tri tuong doi cua mot diem so voi duong tron C(0;0)*/
#include<stdio.h>
int getRelPos ( double x, double y, double r)
{  double d2=x*x + y*y; /* d2= x2+ y2 */
   double r2= r*r; /* r2*/          
   if (d2<r2) return 1 ; /*d2<r2 thi diem do o trong duong tron*/
   else if (d2==r2) return 0 ; /*d2=r2 thi diem do nam tren duong tron*/
   return -1 ; /*Diem do khong thuoc duong tron*/
}
int main()
{double x,y,r;
 printf("Enter a point: ");
 scanf("%lf %lf",&x,&y); 
 printf("Enter radius: "); 
 scanf("%lf",&r); 
while (r<0)
{ scanf("%f",&r);}
if (getRelPos (x,y,r)==1)
printf("The point is in the circle.");
else
if (getRelPos (x,y,r)==0)
printf("The point is on the circle.");
else printf("The point is out of the circle.");
return 0;
}

