import re
name = input("what's your name? ").strip()
if matches := re.search(r"(^.+), *(.+)$",name):
    last = matches.group(1)

    first = matches.group(2)
    name = matches.group(2) + " " + matches.group(1)
print(name)
    
