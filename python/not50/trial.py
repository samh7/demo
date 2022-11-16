import os
def update_score(new_user, user_name, user_score):
    try:
        user_score = int(user_score)
    except ValueError as e:
        print("Error:",e)
        return -1
    if new_user:
        with open("user_scores.txt","a") as file:  
            player = f"\n{user_name}, {user_score}"
            file.write(player)
        return
    else:
        with open("user_scores.txt", "a") as file:
            length = 0
            names = []
            scores = []
            with open("user_scores.txt", "r") as file_:
                for line_ in file_:
                    name, score = line_.split(" ")
                    name = name.strip(",")
                    score = score.strip("\n")
                    names.append(name)
                    scores.append(score)
                    length += 1
            if user_name == name:
                with open("user_scores.tmp", "w") as file1:
                    for i in range(length):
                        if names[i] == user_name:
                            line1 = f"{user_name}, {user_score}\n"    
                            file1.write(line1)
                            continue
                            
                        line1 = f"{names[i]}, {scores[i]}\n"
                        file1.write(line1)
                    # os.remove("user_scores.txt")
                    # os.rename("user_scores.tmp", "user_scores.txt")
        return    
    return -1
                    

update_score(True, "Alice", "245")