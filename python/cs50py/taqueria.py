def main():
    items = {
        "baja taco":4.00,
        "burrito": 7.50,
        "bowl":8.50,
        "nachos":11.00,
        "quesadilla":8.50,
        "super burrito":8.50,
        "super quesadilla":9.50,
        "taco":3.00,
        "tortilla salad":8.00
    }
    get_items(items)
    
def get_items(items):
    tmp_amt = 0
    try:
        while True:
            user_in = input("Items: ").lower()
            tmp_in = "".join(user_in.split())
            if  not tmp_in.isalpha():
                break
            try:
                tmp_amt += items[user_in]
                print(f"Total: ${tmp_amt}")
            except KeyError:
                pass
    except KeyboardInterrupt:
        pass
main()