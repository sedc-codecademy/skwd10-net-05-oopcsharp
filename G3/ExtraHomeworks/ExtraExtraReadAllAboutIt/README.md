# Homework

# Guess the number

 Create a program(game) Guess the number.
The game should be a Console application.
Game rules are for limited tries to guess the number that is randomly generated between two end points.

When the game start it should ask the user for difficulty.
* Easy 
	- In easy mode user should have 9 tries to guess the number between 0-100.
* Normal
	- In normal mode user should have 7 tries to guess the number between 0-500.
* Hard
	- In hard mode user should have 5 tries to guess the number between 0-1000.

Every guess should give the user hint if it is close and also should display the number that the user last entered.
example
- If the number that should be guessed is 10 and the user enters 18 it should print out "Your guess is far to high, number entered: 18".
- If the number that should be guessed is 10 and the user enters 2 it should print out "Your guess is far to low, number entered: 2".
- If the number that should be guessed is 10 and the user enters 7 it should print out "Your guess is a little bit lower, number entered: 7".
- If the number that should be guessed is 10 and the user enters 13 it should print out "Your guess is a little bit higher, number entered: 13".
- If the number that should be guessed is 10 and the user enters 10 it should print out "Nailed it. number entered: 10".
You can add your kind of notifications if you like.

Based on how fast the user guessed the number it should display a proper title and the number that should be guessed.
example
- If user nails it on the first try it should print out "Lucky guess.".
- If user did not guess the number it should print out "Try again".

#### Optional: 
Give the user a chance to restart the game(ex Press 1 to start a new game, press 2 to quit game) without starting the project from scratch.

Tips: Try using the OOP principles that we learned so far.
