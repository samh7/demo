import random, sys
def main():
    level = get_level()
    a_rand = generate_integer(level)
    b_rand = generate_integer(level)
    sum = a_rand + b_rand
    trial = 0
    while True:
        try:
            guess = int(input(f"{a_rand} + {b_rand} = "))
            trial += 1
            if trial == 3:
                print(f"the answer is {sum}")
                sys.exit()
            assert sum == guess
            print("Just Right")
            sys.exit()
        except ZeroDivisionError:
            pass
        except AssertionError:
            pass
        
def get_level():
    while True:
        try:
            r_value = int(input("Level: "))
            #start error check
            assert r_value >= 1
            assert r_value <=3
            #end error check 
            return r_value
        except AssertionError:
            pass     
        except ValueError:
            pass
def generate_integer(level):
    max_int = 10
    if level == 1:
        pass
    else:
        for i in range(level):
            if i == 1:
                continue
            max_int *= 10
    return random.randint(0, max_int)
            
main()