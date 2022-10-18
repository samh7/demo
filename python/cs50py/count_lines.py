import sys
def main():
    print()
def line_count(user_in):
    in_len = len(user_in)
    line_count = 0
    try:
        with open(user_in, "r") as file:
            for row in file:
                if row[0] == "#":
                    continue
                line_count += 1
            return line_count
    except FileNotFoundError:
        return None
if __name__ == "__main__":
    main()