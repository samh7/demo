def main():
    get_list()
    
def get_list():
    item = []
    while True:
        try:
            item.append(input("").upper())
        except KeyboardInterrupt:
            for i in range(len(item)):
                print(f"{i+1} {item[i]}")
            exit()
main()