my_list = ["Ea","Sports", "its in the game, and thats", True]
print(my_list)  ##Whats in the variable
print(type(my_list)) ##Type
print(len(my_list))  ##Length of variable values
print(my_list[0])  ##Prints a specific part of the varaibles value


print(f"We are {my_list}") #Print a list using an F string

my_list.append("We dont take money") ##Adds to list
print(my_list)

my_list.insert(0, "WE DONT MICROTRANSACTION GAMES") ##Adds Value to a specific point within a Variable Value
print(my_list)

my_list.pop() ##Removes last Value or Specific

my_list.remove() ##Removes Value from varaible list
print(my_list)

last_name = my_list.pop(2)  ##Removes specific value
print(my_list)
print(last_name)

another_list = ["Birmingham",32443]
my_list.extend(another_list)  ##Adds another Variable to a specific variable
print(my_list)

my_list.append("EA")
print(my_list.count("EA")) ##Counts 