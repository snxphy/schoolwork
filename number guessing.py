one = ("lol")

import random

guessesTaken = 0

print('I want to play a game. Do you?')
Answer = input()


number = random.randint(1, 99)

print('Well, if no, too bad, I am thinking of a number between 1 and 99.')

##loop
while guessesTaken < 9:
    

    print('Take a guess.')
    guess = input()
    guess = int(guess)

    guessesTaken = guessesTaken + 1

    ##number too low
    if guess < number:

        print('Your guess is too low.') 

    ##number too high
    if guess > number:

        print('Your guess is too high.')

    ##correct number
    if guess == number:
        
        print('Good job, You guessed my number!'+ "Do you want to restart ? Yes or No")
        response = input()
        if not response == "Yes":
            break
        
            

        

   


##Correct Number

if guess == number:

    guessesTaken = str(guessesTaken)
    
    

    


    

##Wrong number

if guess != number:

    number = str(number)
    print('Nope. The number I was thinking of was ' + number)


    