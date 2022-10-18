from plates_2 import validate

def test_1():
    assert validate("CS50") == "valid"
def test_2():
    assert validate("1234") == "invalid"
def test_3():
    assert validate("cs50py") == "invalid"
def test_4():
    assert validate("cs12345") == "invalid" 