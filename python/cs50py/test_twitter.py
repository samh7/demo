from twitter import twttr

def test_1():
    assert twttr("hello") == "hll"
def test_2():
    assert twttr("000") == "000"
def test_3():
    assert twttr("RENDEZVOUS") == "rndzvs"