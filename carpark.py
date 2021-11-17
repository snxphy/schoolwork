##Max
Model_Max = 30
Reg_Max = 8
Colour_Max = 20
Payment_Max = 30

##Minimum
Payment_Min = 1

##Car
Car_reg = True
Car_Make = True
Car_Model = True
Car_Colour = True

##Car Information
Tax = True
MOT = True
Insured = True
Paid = False
Payment = True

##Greeting
print("|----Welcome----|\n")

##Loop Car Registration
while Car_reg:
    Car_reg = input("|----Please Put In Your Car Registration----| \n|----| ")
    if len(Car_reg) > Reg_Max:
        print("|----Car Registration is too long----|\n")
    else:
        break

##Loop Car Brand
while Car_Make:
    Car_Make = input("\n|----Please Put In Your Car Brand----| \n|----| ")
    if len(Car_Make) > Model_Max:
        print("|----Car Brand Input is too long----|\n")
    else:
        break

##Loop Car Model
while Car_Model:
    Car_Model = input("\n|----Please Put In Your Car Model----| \n|----| ")
    if len(Car_Model) > Model_Max:
        print("|----Car Model input is too long----|\n")
    else:
        break

##Loop Car Colour
while Car_Colour:
    Car_Colour = input("\n|----Please Put In Your Car Colour----| \n|----| ")
    if len(Car_Colour) > Colour_Max:
        print("|----Car Colour input is too long----|\n")
    else:
        break


##Loop Payment
while Paid == False:
    try:
        Payment = int(input("\n|----Please Update Payment----| \n|----| £"))
        if Payment > Payment_Max:
            print("|----Payment Error----|\n")
        if Payment < Payment_Min:
            print("|----Payment Error----|\n")
        else:
            print("|----Gate Opening----|\n")
            break
    except ValueError:
        print("|----Payment Awaiting----|\n")


    

        



