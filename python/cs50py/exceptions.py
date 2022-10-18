def main():
    print(get_int("what's x?: "))

def get_int(prompt):
    while True:
        try:
            return int(input(prompt))
        except ValueError:
            pass
            # print("x is not an integer") 
main()