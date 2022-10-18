def main():
    greeting = input("")
    print(greeting_amt(greeting))
    
def greeting_amt(greeting):
    if greeting == "hello":
        print("$0")
    else:
        if greeting[0] == "h":
            return "$20"
        else:
            return "$100"
            
if __name__ == "__main__":
    main()