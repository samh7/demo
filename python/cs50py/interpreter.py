user_in = input(" ")
split_in = user_in.split()
in_len = len(split_in)

if split_in[1] == "+":
    print(f"{int(split_in[0])+int(split_in[2]):.1f}")
elif split_in[1] == "-":
    print(f"{int(split_in[0])-int(split_in[2]):.1f}")    
elif split_in[1] == "*":
    print(f"{int(split_in[0])*int(split_in[2]):.1f}")
elif split_in[1] == "/":
    print(f"{int(split_in[0])/int(split_in[2]): .1f}")