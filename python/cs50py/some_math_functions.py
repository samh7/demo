def main():
    print("hello")
def square(x):
    return x*x
def is_greater(x,y):
    return x > y
def is_lesser(x,y):
    return x <y
def is_equal(x,y):
    return x == y
def is_divisible_by(x,y):
    return (x % y) == 0
def is_number(x):
    try:
        t = x/2
        return True
    except TypeError:
        return False
def is_zero(x):
    try:
        t = 1/x
        return False
    except ZeroDivisionError:
        return True
        return
if __name__ == "__main__":
    main()