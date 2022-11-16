#include<stdio.h>
int main(){
    printf("enter values for: \vpow(R(K(pow(x, y)) \nwhere K is a constant ");
    printf ("multiplied to x, C a constant added to Kx,\n");
    printf("pow y is the power of x, R is the constant multiplied to (K(pow(x, y)) + C) such that: \vy = R(K(pow(x, y)) + C)");
    printf("\nand N is the power of R(K(pow(x, y)) + C) such that: \vy = pow(R(K(pow(x, y)) + C),N)\n");
    //R is the constant ,ultiplied ttp the wjhole equatuion
    int K, y,  C, R,N;
    printf("enter value for K, y, C, N, and R: ");
    scanf("%d%d%d%d%d",&K,&y,&C,&R,&N);
    y+=1;
    if(C>0) 
        printf("%.3fx^(%d) + %dx + c ",((float)K/y),y,C);
    else if(C==0)
        printf("%.3fx^(%d) + c",((float)K/y),y);

    return 0;
}