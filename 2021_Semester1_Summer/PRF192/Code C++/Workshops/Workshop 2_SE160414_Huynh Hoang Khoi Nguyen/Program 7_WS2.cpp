/*The differences between two characters*/
#include<stdio.h>
main () 
{ char c1,c2;
  int d; //Difference
  char t; //Character for swapping
  char c; //Character for looping
  scanf("%c",&c2);
    if(c1>c2)
    { t = c1; c1 = c2; c2 = t;
    }
    d = c2 - c1;
    printf("d:%d",d);
    for (c = c2; c >= c1; c++) 
        { printf("%c : %d, %o, %X\n", c, c, c, c);
		}
	getchar();
	return 0;
}

