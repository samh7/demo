import sys
def main():
    argv_len = len(sys.argv)
    if argv_len < 2:
        sys.exit("too few command_line arguments")
    elif argv_len > 2:
        sys.exit("too many command-line arguments")
    
    user_in = sys.argv[1]
    in_len = len(user_in)

    for i in range((in_len-3), in_len):
        if user_in[i] == ".":
            if user_in[i+1] == "p":
                if user_in[i+2] == "y":
                    break
                else:
                    sys.exit("not a python file")
            else:
                sys.exit("not a python file")
        else:
            sys.exit("not a python file")
    
    line_count = 0
    try:
        with open(user_in, "r") as file:
            for row in file:
                if row[0] == "#":
                    continue
                line_count += 1
            print(line_count)
    except FileNotFoundError:
        sys.exit("Fle does not exist")
if __name__ == "__main__":
    main()