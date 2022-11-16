import os, random
def get_score(user_name):
    if not user_name:
        return -1
    try:
        with open("user_scores.txt", "r") as file:
            for line in file:
                if not len(line):
                    break
                name, score = line.split(" ")
                name = name.strip(",")
                score = score.strip("\n")
                if name == user_name:
                    return int(score)
    except IOError:
        file = open("user_scores.txt", "a")
        file.close()
        return -1
    return -1
def update_score(new_user, user_name, user_score):
    try:
        user_score = int(user_score)
    except ValueError as e:
        print("Error:",e)
        return -1
    if new_user:
        with open("user_scores.txt","a") as file:  
            player = f"{user_name}, {user_score}\n"
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
                    # os.unlink("user_scores.txt")
                    # os.rename("user_scores.tmp", "user_scores.txt")
        return    
    return -1
def get_question():
    operand_list = [0, 0, 0, 0, 0]   
    operator_list = ["", "", "", ""]
    operator_dict = {
        1:"+",
        2:"-",
        3:"*",
        4:"**",
        5:"/"
    }
    answer = -11
    question_string = ""
    while True:
        if (answer <= 50_000) and (answer >= -10):
            break
        for i in range(5):
            operand_list[i] = random.randint(0, 9)
        for j in range(4):
            rand_operator = operator_dict[random.randint(1,5)]
            if (j-1) >= 0:
                if operator_list[j-1] == "**":
                    while rand_operator == "**":
                        rand_operator = operator_dict[random.randint(1,5)]
                if operator_list[j-1] == "/":
                    while rand_operator == "/":
                        rand_operator = operator_dict[random.randint(1,5)]                    
            operator_list[j] = rand_operator
            print(rand_operator)
        
        for k in range(5):
            question_string += str(operand_list[k])
            if k == 4:
                break
            question_string += str(operator_list[k])
        while True:
            try:
                answer = eval(question_string)
                break
            except ZeroDivisionError:
                return get_question()
    question_string = question_string.replace("**", "^")
    tmp_string = []
    plus_operator_index = []
    for l in range(len(question_string)):
        tmp_string.append(question_string[l])
        if question_string[l] == "+":
            plus_operator_index.append(l)
    if len(plus_operator_index) == 2:
        if (plus_operator_index[1] - plus_operator_index[0]) >=4:
            num = (plus_operator_index[1] - plus_operator_index[0]) 
            tmp_string.insert(plus_operator_index[0]+1, "(")
            tmp_string.insert(plus_operator_index[1]+1, ")")
    if len(operand_list) == 3:
        if (plus_operator_index[1] - plus_operator_index[0]) >=4:
            num = (plus_operator_index[1] - plus_operator_index[0]) 
            tmp_string.insert(plus_operator_index[0]+1, "(")
            tmp_string.insert(plus_operator_index[1]+1, ")")
        if (plus_operator_index[2] - plus_operator_index[1]) >=4:
            num = (plus_operator_index[2] - plus_operator_index[1]) 
            tmp_string.insert(plus_operator_index[1]+1, "(")
            tmp_string.insert(plus_operator_index[2]+1, ")")
    
    tmp_string = "".join(tmp_string)
    question_string = tmp_string
    while True:
        try:
            user_in = int(input(f"What is{question_string}\n"))
            break
        except ValueError:
            pass
    if user_in == answer:
        return (5, "correct")
    else:
        return (0, "wrong")