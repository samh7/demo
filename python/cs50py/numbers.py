import sys, re

def main():
    
    print(validate(input("IPv4 Address: ")))

def validate(ip):
    matches = ip.split(".")
    match_len = len(matches)
    for match in matches:
        
        if (match) >= 0:
            if int(match) <= 255:
                return True
            else:
                return False
        else:
            return False
    return False
    return matches
     
if __name__ == "__main__":
    main()