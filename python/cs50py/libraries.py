from statistics import mean
import sys
def main():
    try:
        for name in sys.argv[1:] :             
            print(f"hello my name is {name}")
    except  IndexError:
        print("out of range")
main()