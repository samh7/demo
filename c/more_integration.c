#include<stdio.h>
int s_diff(int K, int t){
    if(t>1)
        return K*(t-1);
    else
        return K*(t);
}
int main(){
    printf("SIMPLE PROGRAM TO FIND  INDEFINATE INTEGRAL OF y = R(K(x^t)+ C)^N\n\n");
    printf("enter values for: \vpow(R(K(pow(x, t)) \nwhere K is a constant ");
    printf ("multiplied to x, C a constant added to Kx,\n");
    printf("t is the power of x, R is the constant multiplied to (K(pow(x, t)) + C) such that: \vy = R(K(pow(x, t)) + C)");
    printf("\nand N is the power of R(K(pow(x, t)) + C) such that: \vy = pow(R(K(pow(x, t)) + C),N)\n");
    int K, t,C, R,N;
    printf("enter value for R, K, t, C, and N: ");
    scanf("%d%d%d%d%d",&R,&K,&t,&C,&N);
    if(N > 1){
        int diff= s_diff(K,t);
        float R2 =  (float)R/(diff*(N+1));
        if (t>1)
            printf("the integral is %.4f((%dx^%d + %d)^%d)/x + c",R2,K,t,C,N+1);
        else        
            printf("the integral is %.4f((%dx^%d + %d)^%d) + c",R2,K,t,C,N+1);
    }
    else{
        if(C>0) 
            printf("%.3fx^(%d) + %dx + c ",((float)K/(t+1)),(t+1),C);
        else if(C==0)
            printf("%.3fx^(%d) + c",((float)K/(t+1)),(t+1));
    }    
    return 0;
}

//tommorrows assignment look on how to make integrate a fucntion
