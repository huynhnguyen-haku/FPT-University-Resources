/*Finding the numbers of vowels, consonants and others*/
#include<stdio.h>
#include<ctype.h>
main ()
{ char ch;
  int nVowels = 0;
  int nConsonants = 0;
  int nOthers = 0;
  
  do {
  	ch = getchar();
  	ch = toupper(ch);
  	if (ch>='A' && ch <='Z')
  	{
  		switch(ch) {
				 case 'A' :
		         case 'E' :
		         case 'I' :
		         case 'O' :
		         case 'U' : 
				 	nVowels++; 
					break;
				default :
					nConsonants++;
	  }
	}
	else nOthers++;
  }
   while (ch != '\n');
	printf("Number of Vowels: %d\n", nVowels);
	printf("Number of Consonants: %d\n", nConsonants);
	printf("Number of Others: %d\n", nOthers);
}
