def main():
#for loops
    pets = ["cat", "dog", "rabbit", "hamster", "goat", "calf"]
    for index, pet in enumerate(pets):
        print(index+1, pet)

#inline if statements
def is_even(my_int):
    return "yes" if my_int %2 == 0 else "no"
def even_or_odd(my_int):
    return "even" if my_int % 2 == 0 else "odd"

if __name__ == "__main__":
    main()