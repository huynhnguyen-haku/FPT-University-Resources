/*Chuong trinh nhap vao cac so 1,2,3. In ra so sao tuong ung*/
 #include <stdio.h>
 #include <conio.h>
 int main ()
 { int i;
   printf("Nhap vao so 1, 2 hoac 3:");
   scanf("%d",&i);
   switch(i)
 { case 3: printf("*");
   case 2: printf("*");
   case 1: printf("*");
 }
printf("An phim bat ky de ket thuc!\n");
getchar ();
return 0;
 }
