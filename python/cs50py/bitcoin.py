import requests, json, sys
def main():    
    if len(sys.argv) == 2:
        pass
    elif len(sys.argv) < 2:
        print("missing command-line argument")
        sys.exit()
    else:
        print("Invalid Command(s)")
    
    try:
        user_in = float(sys.argv[1])
    except ValueError:
        print("command-line argument is not a number")
        sys.exit()  
    
    response = requests.get("https://api.coindesk.com/v1/bpi/currentprice.json")
    # print(json.dumps(response.json(), indent=2))
    # print()
    o = response.json()
    
    cmp_out = user_in * (o["bpi"]["USD"]["rate_float"])
    print(f"{cmp_out:,}")
    
main()