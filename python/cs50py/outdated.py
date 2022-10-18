# outdated format = month, day, year 
# new format = year, month date
def main():
    update_date()
    
def update_date():
    date = {
        "january":1,
        "february":2,
        "march":3,
        "april":4,
        "may":5,
        "june":6,
        "july":7,
        "august":8,
        "september":9, 
        "october":10,
        "november":11,
        "december":12  
    }
    get_date(date)
def get_date(date):
    user_in = input("what's the date? ")
    mon_th = ""
    y_ear = ""
    d_ay = ""
    in_len = len(user_in)

    try:
        if in_len >= 11 or in_len >= 17:
            user_in = user_in.split() 
            mon_th = int(date[user_in[0].lower()])
            for i in range(len(user_in[1])):
                if user_in[1][i] == ",":
                    break
                d_ay += user_in[1][i]
            y_ear = user_in[2]
            d_ay = int(d_ay)
            y_ear = int(y_ear) 
            
            assert y_ear >= 1636
            if y_ear == 1636:
                if mon_th == 9:
                    assert d_ay >= 8
                assert mon_th >= 9
            if (d_ay < 1) or (d_ay > 31):
                return  get_date(date)
                        
            print(f"{y_ear}-{mon_th}-{d_ay}")
        elif in_len <= 10 and in_len >= 8:
            for i in range(in_len): 
                if user_in[i].isalpha():
                    return  get_date(date)
                if user_in[i] == "/":
                    for j in range(i+1,in_len):  
                        if user_in[j] == "/":       
                            for k in range(j+1,in_len): 
                                y_ear += user_in[k]                              
                            mon_th = int(mon_th)
                            d_ay = int(d_ay)
                            y_ear = int(y_ear)                                  
                                                               
                            assert y_ear >= 1636
                            if y_ear == 1636:
                                if mon_th == 9:
                                    assert d_ay >= 8
                                assert mon_th >= 9
                            
                            if d_ay < 1 or d_ay > 31 or mon_th < 1 or mon_th > 12:
                                return  get_date(date)                           
                           
                            print(f"{y_ear}-{mon_th}-{d_ay}")
                            return
                        d_ay += user_in[j]
                mon_th += user_in[i]
        else:
            return get_date(date)
    except ValueError:
        return get_date(date)
    except KeyError:
        return get_date(date)
    except AssertionError:
        return get_date(date)       
if __name__ == "__main__":  
    main()