import tabulate, sys, csv
# dictionarry =  [["name", "house"],
#                 ["SAMMy", "Slytherin"],
#                 ["MARk", "Angel"],
#                 ["Harry", "Gryffindor"],
#                 ["ROnn", "Mark"],
#                 ["hJAin","Slytherin"]
#                 ]
# print(tabulate.tabulate(dictionarry, headers="firstrow", showindex="always",tablefmt="grid" ))
if len(sys.argv) < 2:
    sys.exit("too few command-line arguments")
elif len(sys.argv) > 2:
    sys.exit("too many command-line arguments")
    
with open(sys.argv[1], "r") as file:
    doocu = csv.reader(file)
    print(tabulate.tabulate(doocu , headers="firstrow",tablefmt="grid"))