import sys
def main():
    user_in = []
    # usr_out = "" 
    while True:
        try:
            user_in.append(input("Name: "))
        except EOFError:
            break

    print()

    in_len = len(user_in)
    
    if in_len == 1: 
        print("Adieu, adieu, to " + user_in[0])
        sys.exit()
        
    if in_len == 2:
        print(f"Adieu, adieu, to {user_in[0]} and {user_in[1]}")
        sys.exit()   
        
    new_usr_out =""
    new_usr_in = []
    
    for i in range(in_len):
        if i == in_len - 1:
            new_usr_in.append("and")
        new_usr_in.append(user_in[i])
    
    for j in range(in_len+1):

        new_usr_out += new_usr_in[j]    
        if j == in_len or (new_usr_in[j] == "and"):
           new_usr_out += " "
           continue 
        new_usr_out += ", "
    print("Adieu, adieu, to "+new_usr_out)        

    
main()