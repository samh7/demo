from fuel import fuel_amt

def test_1():
    assert fuel_amt("1/4") == f"{25}%"
def test_2():
    assert fuel_amt("0/1") == "E"
def test_1():
    assert fuel_amt("99/100") == "F"