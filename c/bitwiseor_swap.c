#include<stdio.h>
int main(){
    int a=5, b =25, temp;
    int *x,*y;
    x=&a;
    y=&b;

    temp=*x;
    *x=*y;
    *y=temp;
    printf("a is: %d",a);
    return 0;
}
