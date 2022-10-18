import re
url = input("URL: ").strip()
# username = url.removeprefix("https://twitter.com/")

# username = re.sub(r"(https?://)?(www\.)?twitter\.com/", "", url) 

if matches := re.search(r"^https?://(?:www\.)?twitter\.(?:com|org)/(\w+)$", url, re.IGNORECASE):
    print(f"Username: {matches.group(1)}")