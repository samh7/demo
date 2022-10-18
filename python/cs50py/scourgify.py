import csv,sys, count_lines
if len(sys.argv) < 3:
    sys.exit("too few arguments")
elif len(sys.argv) > 3:
    sys.exit("too many arguments")
    
try:
    with open(sys.argv[1],"r") as file:
        pass
except FileNotFoundError:
    sys.exit("File Not Found")

try:
    with open(sys.argv[2], "r") as file:
        pass
except:
    with open(sys.argv[2],"w") as file:
        pass
names = []
houses = []
list_len = 0
with open(sys.argv[1], "r") as file:
    det_ails = csv.DictReader(file)
    for row in det_ails:
        names.append(row["name"])
        houses.append(row["house"])
        
        list_len += 1     

with open(sys.argv[2], "a", newline="") as file:
    writer = csv.DictWriter(file,fieldnames=["name", "house"], skipinitialspace = "True")    
    if count_lines.line_count(sys.argv[2]) is None or count_lines.line_count(sys.argv[2]) == 0:
        writer.writerow({"name":"name", "house":"house"})
    for i in range(list_len):
        f_name = names[i].split()[1]
        s_name = names[i].split(",")[0]
        full_name = f"{f_name}, {s_name}" 
        writer.writerow({"name":full_name, "house":houses[i]})
        
