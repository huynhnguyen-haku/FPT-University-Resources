/*Write a C-program that helps user managing a list of 100  student names using the following menu:
1- Add a student
2- Remove a student
3- Search a student
4- Print the list in ascending order
5- Quit */

#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <ctype.h>
#define MAXN 100
int GetUserChoice()
{
	int choice;
	printf("\n1_ Add a student");
	printf("\n2_ Remove a student");
	printf("\n3_ Search a student");
	printf("\n4_ Print the list in ascending order");
	printf("\nOthers_ Quit\n");
	printf("\nSelect: ");
	scanf("%d",&choice);
	fflush(stdin);
	return choice;
}
//Testing whether an array is full or not
int isFull(char a[][31],int n)
{
	return n==MAXN;
}
//Testing whether an array is empty or not
int isEmpty(char a[][31],int n)
{
	return n==0;
}
//Correct form of the name user input (remove the blank and uppercase the first character at name)
char* lTrim(char s[])	//remove blank at left
{	int i=0;
	while (s[i]==' ') i++;
	if (i>0) strcpy(&s[0],&s[i]);
	return s;
}

char* rTrim(char s[])	//remove blank at right
{	int i=strlen(s)-1;
	while (s[i]==' ') i--;
	s[i+1]='\0';
	return s; 
}

char* trim(char s[])	//remove blank at middle
{	lTrim(rTrim(s));
	char *find=strstr(s,"  ");
	while (find!=NULL) 
	{
		strcpy(find,find+1);
		find=strstr(s,"  ");
	}
	return s;
}

char *nameStr(char s[])	//uppercase first character
{	trim(s);
	strlwr(s);
	int l=strlen(s);
	for (int i=0; i<l; i++) 
		if (i==0 || (i>0 && s[i-1]==' ')) s[i]=toupper(s[i]);
	return s;
}
//adding an element to the end of array will increase number of elements
void add(char value[31],char a[][31],int *pn)
{
	strcpy(a[*pn],value);
	(*pn)++;
}
int search(char x[31],char a[][31],int n)
{
	int i;
	for(i=0;i<n;i++) if(strstr(a[i],x)!=NULL) return i;
	return -1;
} 
//Removing the element at a position in an array will decrease number of elements 
//return 1:remove successfully, 0:remove fail
int RemoveOne(int pos,char a[][31],int *pn)
{
	if(pos<0||pos>=*pn) return 0;
	
	for(int i=pos;i<*pn-1;i++) strcpy(a[i],a[i+1]);
	(*pn)--;
	return 1;
}
void print(char a[][31],int n)
{
	for(int i=0;i<n;i++) puts(a[i]);
}
void ArrangeAscending(char a[][31],int n)
{
	char t[31];
	for(int i=0;i<n-1;i++)
	{
		for(int j=n-1;j>i;j--)
		{
			if(strcmp(a[j],a[j-1])<0)
			{
				strcpy(t,a[j]);
				strcpy(a[j],a[j-1]);
				strcpy(a[j-1],t);
			}
		}
	}
}
int main ()
{   int getchoice;char a[MAXN][31];
    int n=0;char value[31];
	do
	{
		getchoice=GetUserChoice();
		switch(getchoice){
			case 1:
				{
					if(isFull(a,n)) printf("\nSorry! The Array is full.\n");
					else
					{
						printf("Input an added value:");
						gets(value);
						strupr(value);
						add(value,a,&n);
						printf("Added\n");
					}
					break;
				}
			case 2:
				{	if(isEmpty(a,n)) printf("\nSorry! The Array is empty.\n");
					else
					{
						printf("Name of student:");
						gets(value);
						int pos=search(value,a,n);
						if(pos<0) printf("Not found!\n");
						else
						{
							RemoveOne(pos,a,&n);
							printf("Removed!\n");
						}
						
					}				
				    break;
				}
			case 3:
				{
					char x[31];
					printf("Name of student:");
					gets(x);
					if(search(x,a,n)<0) printf("Not found!\n");
					else printf("Position is found:%d",search(x,a,n)+1);
					break;
				}
			case 4:
				{
					ArrangeAscending(a,n);
					print(a,n);
					break;
				}
			default: printf("Good bye!\n");
		}
		
	}while(getchoice>=1&&getchoice<=4);
	return 0;
}
