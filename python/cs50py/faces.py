# print("hello,","\N{slightly smiling face}")
# print("hello,","\N{slightly frowning face}")

user_in = input("")
user_in_split = user_in.split()

in_length = len(user_in_split)
for i in range(in_length):
    while i-1 > -1: 
        if user_in_split[i] == ":)":
            print(user_in_split[i-1] + " \N{slightly smiling face} ", end="")
        if user_in_split[i] == ":(":
            print(user_in_split[i-1] + " \N{slightly frowning face} ", end="")
        break
        

        
        

