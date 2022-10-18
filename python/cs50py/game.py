from random import randint
def main():
    while True:
        try:
            n = int(input("Level: "))            
            #start error check
            if n < 1:
                t = 1/0 
            #end error check  
            break
        except ZeroDivisionError:
            pass 
        except ValueError:
            pass
    cmp_guess = randint(1, n)
    guess = 0
    while not is_win(cmp_guess, guess):
        while True:
            try:
                guess = int(input("Guess: "))
                #start error check
                if guess < 1:
                    t = 1/0
                #end error check  
                if guess < cmp_guess:            
                    print("Too Small")
                elif guess > cmp_guess:
                    print("Too Large")
                break
            except ZeroDivisionError:
                pass         
            except ValueError:
                pass
    print("Just Right")
      
def is_win(computer_guess,usr_guess):
    return (usr_guess == computer_guess)
    
main()







