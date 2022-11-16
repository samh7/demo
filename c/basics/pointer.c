#include<stdio.h>
int main(){
    int a =  5, b = 25, tmp;
    int *x , *y;
    x = &a;
    y = &b;

    printf("%s",*x);
    return 0;
}