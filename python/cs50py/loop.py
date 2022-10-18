def main():
    print_square(3)

def print_square(size):
    for i in range(size):
        # print("#" * size)
        for j in range(size):
            print("#", end="")
        print()
if __name__ == "__main__":
    main()