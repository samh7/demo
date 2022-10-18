name = input("name:  ")
match name:
    case "Harry" | "Ron" | "David":
        print("house 1")
    case "Hermione":
        print("house 2")
    case _:
        print("no vaccancies")
