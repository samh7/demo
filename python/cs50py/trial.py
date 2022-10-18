item = []
while True:
    try:
        user_in = input("")
        item += user_in
    except EOFError:
        for i in range(len(items)):
            # print(f"{i+1} {items[i]}")
            pass