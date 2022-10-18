def main():
    user_in = input("enter a vanity plate number: ")
    print(validate(user_in))
def validate(user_in):
    in_len = len(user_in)
    if in_len < 2 or in_len > 6:
        return "invalid"
    for i in range(2):
        if not user_in[i].isalpha():
            return "invalid"
    if not user_in.isalnum():
        return "invalid"
    for i in range(2,in_len):
        if i+1 == in_len:
            break
        if user_in[i].isdigit() and user_in[i+1].isalpha():
            return "invalid"
    return "valid"    
if __name__ =="__main__":
    main()