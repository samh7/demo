import csv
name = input("what's your name? ")
home = input("Where's your home? ")
with open("student.csv","a") as file:
    writer = csv.DictWriter(file, fieldnames=["name","home"])
    writer = writer.writerow({"name":name, "home":home})
    