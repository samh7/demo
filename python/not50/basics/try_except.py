my_int = 0
value = 2

try:
    new_int = value / my_int
except ZeroDivisionError as e:
    print("Error:", e)