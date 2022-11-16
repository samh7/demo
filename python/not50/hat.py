import random
class Hat():
    houses = ["rayven", "gryffin", "huffle", "slytherin"]
    @classmethod
    def sort(cls, name):
        print(name + " is in " + random.choice(cls.houses))
        
name = "harry" 

hat = Hat()
hat.sort("hello")
# Hat.sort(name)