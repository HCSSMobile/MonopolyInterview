This exercise is meant to assess problem solving skills and object oriented design instincts. Limit the exercise to two hours, it is not necessary to complete 100% of the functionality, but it should compile and run correctly for the features that you implement.

Write an object-oriented solution to the following problem:

You are implementing an initial solution to the game monopoly. You can make this a command line game where the user enters two parameters: number of players and number of rounds. Your version of the game does not have property squares yet, but you do have the following special squares:
Go Square - passing over this square credits the player $200
Go to Jail Square - landing on this square takes the player to jail
Jail Square
If a player lands here as a result of a dice roll (rather than landing on the Go to Jail Square), they are Just Visiting and can leave at any time.
If a player is transferred to this square as a result of landing on the Go to Jail Square, they must roll doubles to leave. If they do not roll doubles, they lose their turn.
If the player does not roll doubles on their third try, they lose $50 and move the number of spaces they rolled.
Income Tax Square - landing on this square makes the player lose $200 or 10% of their total assets, whichever is less
Luxury Tax Square - landing on this square makes the player lose $75
The image attached will show you the placement of these special squares on the board (outlined in red). The rest of the squares are not special for now.

Each player gets one turn per round. The player rolls two six-sided die and moves the number of spaces specified by the sum of the die. Each player starts with $1500. The winning player is the player with the most money after the specified number of turns.

Example output (there is also a file attached that has more runs of the game):

How many players?: 4
How many rounds?: 30
Player 1 rolled a 7 current square is now Square 7, balance is $1500
Player 2 rolled a 8 current square is now Square 8, balance is $1500
Player 3 rolled a 9 current square is now Square 9, balance is $1500
Player 4 rolled a 9 current square is now Square 9, balance is $1500

Player 1 rolled a 4 current square is now Square 11, balance is $1500
Player 2 rolled a 7 current square is now Square 15, balance is $1500
Player 3 rolled a 6 current square is now Square 15, balance is $1500
Player 4 rolled a 7 current square is now Square 16, balance is $1500

Player 1 rolled a 4 current square is now Square 15, balance is $1500
Player 2 rolled a 5 current square is now Square 20, balance is $1500
Player 3 rolled a 10 current square is now Square 25, balance is $1500
Player 4 rolled a 6 current square is now Square 22, balance is $1500

Player 1 rolled a 10 current square is now Square 25, balance is $1500
Player 2 rolled a 4 current square is now Square 24, balance is $1500
Player 3 rolled a 8 current square is now Square 33, balance is $1500
Player 4 rolled a 5 current square is now Square 27, balance is $1500

Player 1 rolled a 8 current square is now Square 33, balance is $1500
Player 2 rolled a 7 current square is now Square 31, balance is $1500
Player 3 rolled a 6 current square is now Square 39, balance is $1500
Player 4 rolled a 5 current square is now Square 32, balance is $1500

Player 1 rolled a 3 current square is now Square 36, balance is $1500
Player 2 rolled a 10 current square is now Go Square, balance is $1700
Player 3 rolled a 5 current square is now Square 3, balance is $1700
Player 4 rolled a 8 current square is now Square 40, balance is $1500

Player 1 rolled a 9 current square is now Income Tax Square, balance is $1530
Player 2 rolled a 5 current square is now Square 5, balance is $1700
Player 3 rolled a 2 current square is now Square 5, balance is $1700
Player 4 rolled a 3 current square is now Square 2, balance is $1700

Player 1 rolled a 3 current square is now Square 7, balance is $1530
Player 2 rolled a 7 current square is now Square 12, balance is $1700
Player 3 rolled a 4 current square is now Square 9, balance is $1700
Player 4 rolled a 7 current square is now Square 9, balance is $1700

Player 1 rolled a 11 current square is now Square 18, balance is $1530
Player 2 rolled a 11 current square is now Square 23, balance is $1700
Player 3 rolled a 5 current square is now Square 14, balance is $1700
Player 4 rolled a 7 current square is now Square 16, balance is $1700

Player 1 rolled a 6 current square is now Square 24, balance is $1530
Player 2 rolled a 8 current square is now Square 31, balance is $1700
Player 3 rolled a 12 current square is now Square 26, balance is $1700
Player 4 rolled a 7 current square is now Square 23, balance is $1700

Player 1 rolled a 8 current square is now Square 32, balance is $1530
Player 2 rolled a 8 current square is now Square 39, balance is $1700
Player 3 rolled a 4 current square is now Jail Square, balance is $1700
Player 4 rolled a 7 current square is now Jail Square, balance is $1700

Player 1 rolled a 8 current square is now Square 40, balance is $1530
Player 2 rolled a 9 current square is now Square 7, balance is $1900
Player 3 rolled a 7 current square is now Jail Square, balance is $1700
Player 4 rolled a 10 current square is now Jail Square, balance is $1700

Player 1 rolled a 6 current square is now Square 5, balance is $1730
Player 2 rolled a 5 current square is now Square 12, balance is $1900
Player 3 rolled a 5 current square is now Jail Square, balance is $1700
Player 4 rolled a 6 current square is now Jail Square, balance is $1700

Player 1 rolled a 8 current square is now Square 13, balance is $1730
Player 2 rolled a 10 current square is now Square 22, balance is $1900
Player 3 rolled a 8 current square is now Square 18, balance is $1650
Player 4 rolled a 4 current square is now Square 14, balance is $1700

Player 1 rolled a 9 current square is now Square 22, balance is $1730
Player 2 rolled a 6 current square is now Square 28, balance is $1900
Player 3 rolled a 10 current square is now Square 28, balance is $1650
Player 4 rolled a 6 current square is now Square 20, balance is $1650

Player 1 rolled a 7 current square is now Square 29, balance is $1730
Player 2 rolled a 6 current square is now Square 34, balance is $1900
Player 3 rolled a 9 current square is now Square 37, balance is $1650
Player 4 rolled a 3 current square is now Square 23, balance is $1650

Player 1 rolled a 9 current square is now Luxury Tax Square, balance is $1655
Player 2 rolled a 6 current square is now Square 40, balance is $1900
Player 3 rolled a 6 current square is now Square 2, balance is $1850
Player 4 rolled a 3 current square is now Square 26, balance is $1650

Player 1 rolled a 9 current square is now Square 6, balance is $1855
Player 2 rolled a 7 current square is now Square 6, balance is $2100
Player 3 rolled a 6 current square is now Square 8, balance is $1850
Player 4 rolled a 12 current square is now Luxury Tax Square, balance is $1575

Player 1 rolled a 7 current square is now Square 13, balance is $1855
Player 2 rolled a 8 current square is now Square 14, balance is $2100
Player 3 rolled a 7 current square is now Square 15, balance is $1850
Player 4 rolled a 7 current square is now Income Tax Square, balance is $1598

Player 1 rolled a 5 current square is now Square 18, balance is $1855
Player 2 rolled a 7 current square is now Square 21, balance is $2100
Player 3 rolled a 9 current square is now Square 24, balance is $1850
Player 4 rolled a 4 current square is now Square 8, balance is $1598

Player 1 rolled a 7 current square is now Square 25, balance is $1855
Player 2 rolled a 8 current square is now Square 29, balance is $2100
Player 3 rolled a 6 current square is now Jail Square, balance is $1850
Player 4 rolled a 5 current square is now Square 13, balance is $1598

Player 1 rolled a 12 current square is now Square 37, balance is $1855
Player 2 rolled a 7 current square is now Square 36, balance is $2100
Player 3 rolled a 7 current square is now Jail Square, balance is $1850
Player 4 rolled a 4 current square is now Square 17, balance is $1598

Player 1 rolled a 6 current square is now Square 2, balance is $2055
Player 2 rolled a 8 current square is now Square 3, balance is $2300
Player 3 rolled a 4 current square is now Jail Square, balance is $1850
Player 4 rolled a 7 current square is now Square 24, balance is $1598

Player 1 rolled a 4 current square is now Square 6, balance is $2055
Player 2 rolled a 7 current square is now Jail Square, balance is $2300
Player 3 rolled a 8 current square is now Square 18, balance is $1800
Player 4 rolled a 5 current square is now Square 29, balance is $1598

Player 1 rolled a 7 current square is now Square 13, balance is $2055
Player 2 rolled a 8 current square is now Square 18, balance is $2300
Player 3 rolled a 10 current square is now Square 28, balance is $1800
Player 4 rolled a 7 current square is now Square 36, balance is $1598

Player 1 rolled a 6 current square is now Square 19, balance is $2055
Player 2 rolled a 8 current square is now Square 26, balance is $2300
Player 3 rolled a 8 current square is now Square 36, balance is $1800
Player 4 rolled a 12 current square is now Square 7, balance is $1798

Player 1 rolled a 6 current square is now Square 25, balance is $2055
Player 2 rolled a 8 current square is now Square 34, balance is $2300
Player 3 rolled a 9 current square is now Income Tax Square, balance is $1800
Player 4 rolled a 8 current square is now Square 15, balance is $1798

Player 1 rolled a 9 current square is now Square 34, balance is $2055
Player 2 rolled a 7 current square is now Go Square, balance is $2500
Player 3 rolled a 7 current square is now Square 11, balance is $1800
Player 4 rolled a 7 current square is now Square 22, balance is $1798

Player 1 rolled a 8 current square is now Square 1, balance is $2255
Player 2 rolled a 6 current square is now Square 6, balance is $2500
Player 3 rolled a 3 current square is now Square 14, balance is $1800
Player 4 rolled a 6 current square is now Square 28, balance is $1798

Player 1 rolled a 8 current square is now Square 9, balance is $2255
Player 2 rolled a 7 current square is now Square 13, balance is $2500
Player 3 rolled a 8 current square is now Square 22, balance is $1800
Player 4 rolled a 8 current square is now Square 36, balance is $1798


Player 2 is the winner with $2500