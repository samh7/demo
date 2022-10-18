#include<string.h>
#include<stdio.h>
//research on #error and #pragma
//#define TRACE {printf("the name of this source file is: %s and it has %d line\n",__FILE__,__LINE__);}
//feof return 1 if no file and 0 if file read successfully
int main(){



    strcmp();
    int value;
    while(1){
        printf("enter a number: \n");
        fflush(stdin);
        if(fscanf(stdin,"%d",&value)==1){       
            printf("value: %d\n",value);
        }
        printf("not a valid integer\n");
        return 1;
    }




}