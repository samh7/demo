def main():
    in_pt = input("Fraction: ")
    print(fuel_amt( in_pt))
                  
def fuel_amt(in_pt):
    while True:
        in_len = len(in_pt)
        f_left = ""
        f_right = ""
        for i in range(in_len):
            if in_pt[i] == "/":
                break
            f_left += in_pt[i]
        for j in range(in_len):
            if in_pt[j] == "/":                       
                for k in range(j+1,in_len,1):
                    f_right+= in_pt[k]      
        try:   
            f_right = int(f_right)
            f_left = int(f_left)
            assert f_right > 0
            amt = (f_left/f_right) * 100
            break
        except ZeroDivisionError:
            pass
        except AssertionError:
            pass
        except ValueError:
            pass 
    if amt >= 99:
        return "F"
    elif amt <= 1:
        return "E"
    else:
        return f"{amt:.0f}%"
if __name__ == "__main__":
    main()