#include <Stdio.h>
#include <conio.h>
int main () {
	int ia,ib;
	printf("Nhap vao so a");
	scanf("%d",&ia);
	printf("Nhap vao so b");
	scanf("%d",&ib);
	if (ia>ib)
	printf("a lon hon b.\n");
	if (ia<ib)
	printf("a nho hon b.\n");
	else
	printf("a bang b.\n");
	getch();
}
