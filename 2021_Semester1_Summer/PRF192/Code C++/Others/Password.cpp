#include <stdio.h>
#define PASSWORD 123456
int main ()
{ int in;
  do
  {printf("Nhap vao password:");
  scanf("%d",&in);
  }
  while (in !=PASSWORD);
}
