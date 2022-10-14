#include<stdio.h>
#include<stdlib.h>
#define FILENAM "D:/FPT University/Course/PRF192/Code C++/Chiko.txt"

void nhapmang(int a[], int n){
	for(int i = 0; i < n; i++)
	{
		printf("a[%d] = ", i+1);
		scanf("%d", &a[i]);
	}
}

void hienthimang(int a[], int n){
	for(int i = 0; i < n; i++)
	    printf("%3d", a[i]); 
}

void ghitaptin(int a[], int n){
    FILE *f;
	//Mo file 
	f = fopen(FILENAM,"w");
	if(f=NULL){
		printf("Khong mo duoc tep tin\n");
		return; 
	}  
	//Ghi so phan tu vao file 
	fprintf(f, "%d\n",n);
	//Ghi noi dung mang vao file
	for(int i = 0; i < n; i++){
		fprintf(f,"%3d",a[i]); 
	} 
	//Dong file
	fclose(f);
	printf("Ghi thanh cong\n"); 
}
void doctaptin(){
	FILE *f;
	f = fopen(FILENAM,"r");
	if(f==NULL){
		printf("Khong mo duoc tep tin\n");
		return; 
	} 
	//Doc so phan tu
	int n;
	fscanf(f,"%d",&n);
	printf("So phan tu cua mang la %d\n",n);
	int tmp;
	//Duyet mang tu file
	for (int i = 0; i < n; i++){
	fscanf(f,"%d",&tmp);
	printf("%3d", tmp); 
    }
	//Dong file
	fclose(f); 
}
main()
{
	int n, a[100];
	while(true)
	{
		printf("1.Nhap mang\n");
		printf("2.Hien thi mang\n");
		printf("3. Ghi ra tep tin\n");
		printf("4. Doc noi dung tu tep tin");
		printf("5. Thoat\n");
		printf("Hay chon xu ly\n");
		int opt;
		scanf("%d",&opt);
		switch(opt)
		{
			case 1:
				printf("Nhap so phan tu n =\n");
				scanf("%d",&n);
				nhapmang(a,n);
				break;
			case 2:
				hienthimang(a,n);
				break;
			case 3:
				ghitaptin(a,n);
				break;
			case 4:
				doctaptin();
				break;
			case 5:
				exit(0);
		}
	}
}
