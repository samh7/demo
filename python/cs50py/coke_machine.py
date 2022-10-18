def main():
    user_in = int(input("gimme something: "))
    user_in = calc_bal(user_in)    
def calc_bal(user_in):
    if user_in == 50:
        print("no amount due")
        return 0
    else:
        while user_in != 50:
            if user_in > 50:
               print(f"we owe you {(50-user_in)*-1}")
               return 0
            print(f"{50-user_in} is due")
            tmp_in = int(input("top up your amount: "))
            user_in+=tmp_in
        print("no amount due")
        return 0     
    return -1       

main()