import pyfiglet, sys
def main():
    try:
        f_ont = "slant"
        print(pyfiglet.figlet_format("HELLO, WORLD", font=f_ont))
    except pyfiglet.FontNotFound:
        sys.exit()
main()