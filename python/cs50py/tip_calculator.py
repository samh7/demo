def main():
    dollars = dollars_to_float(input("how much was the meal? "))
    percent = percent_to_float(input("what percentage would you like to tip: "))
    tip = dollars * (percent/100)
    print(f"leave: ${tip: .2f}")


def dollars_to_float(d):
    d_len = len(d)
    if d[0] == "$":
        d_return = []
        for i in range(d_len):
            if (i + 1) > (d_len - 1):
                break
            d_return += d[i+1]  
        d_ret = "".join(d_return)
        return float(d_ret)
    return -1.0

def percent_to_float(p):
    p_len = len(p)
    if p[p_len - 1] == "%":
        p_return = []   
        for i in range(p_len):
            if i == p_len - 1:
                break
            p_return += p[i]
        p_return = "".join(p_return)
        return float(p_return)
    return -1.0

main() 