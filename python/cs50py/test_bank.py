from bank import greeting_amt

def test_1():
    greeting_amt("hello") == "$0"
def test_2():
    greeting_amt("ola") == "$100"
def test_3():
    greeting_amt("hi") == "$20"
    