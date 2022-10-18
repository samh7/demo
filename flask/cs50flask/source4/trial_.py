import csv
file = open("trial.csv","a")
writer = csv.writer(file)
writer.writerow(("hwllo", "hwllo"))
file.close()
writer.writerow("c ev")