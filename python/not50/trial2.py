import random
operand_list = [0, 0, 0, 0, 0]   
operator_list = ["", "", "", "", ""]
operator_dict = {
    1:"+",
    2:"-",
    3:"*",
    4:"**",
}
for i in range(5):
    operand_list[i] = random.randint(0, 9)
for j in range(5):
    rand_operator = operator_dict[random.randint(1,4)]
    if (j-1) >= 0:
        if operator_list[j-1] == "**":
            while rand_operator == "**":
                rand_operator = operator_dict[random.randint(1,4)]
    operator_list[j] = rand_operator
    print(rand_operator)
question_string = ""
for k in range(5):
    question_string += str(operand_list[k])
    if k == 4:
        break
    question_string += str(operator_list[k])
print(question_string)
answer = eval(question_string)
print("answer: ", answer)

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
print(tmp_string)       
print(plus_operator_index)
while True:
    try:
        user_in = int(input(f"What is{question_string}\n"))
        break
    except ValueError:
        pass
print(user_in)