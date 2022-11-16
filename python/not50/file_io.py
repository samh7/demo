import csv
file = open("books.csv", "a")
book_name = input("Book Name: ")
author = input("Author: ")
year = input("Year: ")
# writer = csv.writer(file)
# writer.writelines(name)
entry = []
entry.append(book_name)
entry.append(author)
entry.append(year)

writer = csv.writer(file)
writer.writerow(entry)
file.close()