def get_len(csv_file_name):
    list_len = 0
    with open(csv_file_name, "r") as file:
        det_ails = csv.DictReader(file)
        for row in det_ails:
            list_len += 1
        
def get_name(csv_file_name):
    with open(csv_file_name, "r") as file:
    det_ails = csv.DictReader(file)
    for row in det_ails:
        names.append(row["name"])


