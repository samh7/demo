#include<stdio.h>
//research on #error and #pragma
//short,int,long
//&, |, ^, ~ logical opertors
//>> shifts bits to the right ie the left bit if filled with a zero(0)
//1 byte = 8 bits, char stores 1 byte 

//bitfields
struct int_bietfiled{
    int regbase:4;
    int rambase:4;
}
reg;


union timer{
    short timer;
    struct timer_bytes {
        char timerLO;
        char timerHI;
    }timer_bytes;
}the_timer;

enum directions{
    North,South,East,West
};
int main(){
    reg.regbase = 0xc;
    reg.rambase = 0x1;
    //printf("%d\n%d",reg.rambase,reg.regbase);
    printf("%d\n%d\n%d\n%d\n",North,South,East,West);
    return 0;
}