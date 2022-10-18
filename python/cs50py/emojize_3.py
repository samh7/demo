import emoji
def main():
    usr_in = input("Input: ")
    to_emoji(usr_in)
def to_emoji(usr_in):
    in_len = len(usr_in)
    tmp_in = ""
    tmp_emj = ""
    for i in range(in_len):
        if usr_in[i] == ":":
            j = i
            while j+1 < in_len-1:   
                if usr_in[j+1] == ":":
                    break
                tmp_emj += usr_in[j+1]
                j += 1
            break
        tmp_in += usr_in[i]
    print(tmp_in + emoji.emojize(f":{tmp_emj}:",language="alias"))
    return
main()