#include<stdio.h>
#include<string.h>
//determine whether a string is a permuation of another, whitespace is relevant, case isn't
typedef char *string;
int perm_test(string s1, string s2){
	int l1= strlen(s1);
	int l2 = strlen(s2);
	char new_s1[l1];
	int n=0;
	l1-=1;
	while(l1>(-1)){
	new_s1[n]=s1[l1];
	n++;
	l1--;
	}
	return strcmp(new_s1,s2);
}
int main(){
	string s1 = "doof";
	string s2 = "food";
	int truth=perm_test(s1,s2);
	if (truth == 0)
		printf("it is a permutation\n");
	else
		printf("not a permutation\n");
	return 0;
}
