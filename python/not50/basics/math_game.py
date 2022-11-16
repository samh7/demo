import my_functions
user_name = str(input("Name: "))
user_score = my_functions.get_score(user_name)
new_user = False
if user_score == -1:
    new_user = True
    user_score = 0
# user_choice = 0
new_score = 0
# if user_choice != -1:
game = my_functions.get_question()
new_score = game[0]
my_functions.update_score(new_user, user_name, user_score+new_score)

print(game[1])