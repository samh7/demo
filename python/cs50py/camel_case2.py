def main():
    user_in = input("hello: ")
    get_snake_case(user_in)

def get_snake_case(user_in):
    in_len = len(user_in)
    for i in range(in_len):
        if user_in[i] == user_in[i].upper():
            print("_",end="")    
        print(user_in[i].lower(),end="")
     
main()