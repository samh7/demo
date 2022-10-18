import re
email = input("what's your email? ").strip()

if re.search(r"^\w+@(\w+\.){0,10}\w+\.edu$", email, re.IGNORECASE):
    print("valid")
else:
    print("Invalid")