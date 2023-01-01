cost_table = {
    'Charlotte':183,
    'Tampa':220,
    'Pittsburgh':222,
    'Los Angeles':475
    }

def hotel_cost(nights):
    cost = 140 * int(nights)
    return cost

def plane_ride_cost(city):
    return cost_table[city]

def rental_car_cost(days):
    discount_3 = 40 * days * 0.2
    discount_7 = 40 * days * 0.5
    total_rent3 = 40 * days - discount_3
    total_rent7 = 40 * days - discount_7
    cost_day = 40 * days

    if days >= 3:
        return total_rent3
    elif days >= 7:
        return total_rent7
    else:
        return cost_day

def trip_cost(city, nights, car_days):
    total = hotel_cost(nights) + plane_ride_cost(city) +\
            rental_car_cost(car_days)
    return total

city = None
while True:
    city = raw_input ("What's our destination?\n")
    if city not in cost_table:
        print ("That's not a valid destination.")
    else:
        break

hotel_nights = raw_input ("\nHow many nights will you stay?\n")
car_days = raw_input ("How many days will you rent the car?\n")

total_trip_cost = hotel_cost(int(hotel_nights)) +\
                  plane_ride_cost(city) +\
                  rental_car_cost(int(car_days))

print ("The total cost with the trip is", total_trip_cost, "dollars.")