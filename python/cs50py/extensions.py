user_in = input("enter a filename: ")

in_len = len(user_in)
tmp_in = ""
for i in range(in_len):
    if user_in[i] == ".":
        for j in range(in_len - i):
            if (i + 1) <= (in_len - 1):
                i+=1
                tmp_in += user_in[i]
if tmp_in.lower() == "gif":
    print(f"gif/{tmp_in.lower()}")
elif tmp_in.lower() == "jpg" or tmp_in.lower() == "jpeg" or tmp_in.lower() == "png":
    print(f"image/{tmp_in.lower()}")
elif tmp_in.lower() == "pdf" or tmp_in == "txt":
    print(f"application/{tmp_in.lower()}")
elif tmp_in == "zip":
    print(f"compressed/{tmp_in.lower()}")
else:
        print("application/octet-stream")