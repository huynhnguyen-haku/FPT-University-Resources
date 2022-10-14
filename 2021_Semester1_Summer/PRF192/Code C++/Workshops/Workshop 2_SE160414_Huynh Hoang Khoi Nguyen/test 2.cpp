/*Yearly Personal Income Tax*/
#include <stdio.h>
#include <conio.h>

int main()
{
	float income, tf, ti, it;
	int n;
	int pa = 9000000; //Tien nuoi duong ban than
	int pd = 3600000; //Tien chu cap gia dinh
	
	printf("Your yearly income:");
	scanf("%f",&income); //Nhap vao tong thu nhap mot nam
	printf("Number of depentent:");
	scanf("%d",&n); //Nhap so luong nguoi phu thuoc
	tf = 12*(pa+(n*pd));
	printf("Tax-free income: %.0f\n",tf);
	ti = income - tf;
	if(ti<=0) 
	{
		ti= 0;
		it= 0;
	}
	else if (ti<=5000000) 
	{
		it= ti*5/100;
	}
	else if (ti>5000000 && ti<=10000000) 
	{
		it= 5000000*5/100 + (ti-5000000)*10/100;
	}
	else if (ti>10000000 && ti<=18000000) 
	{
		it= 5000000*5/100 + 5000000*10/100 + (ti-10000000)*15/100;
	}
	else if (ti>18000000) {
		it= 5000000*5/100 + 5000000*10/100 + 8000000*15/100 + (ti-18000000)*20/100;
	}
printf ("Income tax: %.0f", it);
getchar (); 
return 0;
}
 
