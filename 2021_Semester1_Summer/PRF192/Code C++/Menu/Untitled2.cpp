/*Sakura.gun*/
#include<stdio.h>
/*Funtion for getting a choice from user - Menu*/
int getUserChoice()
{ int choice; /*Choice from user*/
  printf("\n1-Phep cong hai so:");
  printf("\n2-Phep tru hai so:");
  printf("\n3-Phep nhan hai so:");
  printf("\n4-Phep chia hai so:");
  printf("\nOthers-Quit");
  /*Accept user choice*/
  printf("\nLua chon cua ban:");
  scanf("%d%*c", &choice);
  return choice;
}
/*Function for Phep cong hai so*/
int sum(int a, int b)
{ int n1, n2, sum; /*2 integers*/
  printf("Xin hay nhap 2 so:");
  scanf("%d%d%*c", &n1, &n2);
  sum = n1 + n2;
  printf("Tong cua hai so la: %d\n", sum);
}
/*Function for Phep tru hai so*/
int sub(int a, int b)
{ int n1, n2, sub; /*2 integers*/
  printf("Xin hay nhap 2 so:");
  scanf("%d%d%*c", &n1, &n2);
  printf("Hieu cua hai so la: %d\n", sub);
} 
/*Function for Phep nhan hai so*/
int multi(int a, int b)
{ int n1, n2, multi; /*2 integers*/
  printf("Xin hay 2 so:");
  scanf("%d%d%*c", &n1, &n2);
  printf("Tich cua hai so la: %d\n", multi);
}
/*Function for Phep chia hai so*/
int div(int a, int b)
{ int n1, n2, div; /*2 integers*/
  printf("Xin hay 2 so:");
  while (n2=0)
 { printf("Xin hay nhap 2 so, n2 =/= 0:");
   scanf("%d%d%*c", &n1, &n2);
 }
  scanf("%d%d%*c", &n1, &n2);
  printf("Thuong cua hai so la: %d\n", div);
} 
int main ()
{ int userChoice;
  do
    { userChoice = getUserChoice();
      switch(userChoice)
      { case 1: function1(); break;
        case 2: function2(); break;
        default: printf("Tam biet!\n");
	  }
	}
	while (userChoice>0 && userChoice<3);
	fflush(stdin);
	getchar()
	return 0;
}



