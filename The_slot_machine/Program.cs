using System.Collections.Generic;

namespace The_slot_machine // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Plan for the slot machine code:
            // 1. Instructions.

            Console.WriteLine("Welcome to the slot mashine");
            Console.WriteLine("The rools to the game:");
            Console.WriteLine("1. Add your game money amount in $ USD");
            Console.WriteLine("2. Choose how many lines you would like to play.");
            Console.WriteLine("3. One line cost 1$ per game");
            Console.WriteLine("4. More lines yyou choosee more chance to win!");
            Console.WriteLine("5. Options to choose for the lines:  \n\t1. Center Line.\n\t2. All horizontal lines.\n\t3. All vertical lines.\n\t4. Diagonals.");

            // 2. Choose option for bidding (player choose amount to play $). 
            
            // add if statement to check if input is empty or null
            Console.WriteLine("Add your amount of game money in USD $");
            int playersGameMoney = int.Parse(Console.ReadLine()); // Converting input to int directly, because later it will be used only as int
            Console.WriteLine("Choose how many lines you will play by typing in number of the menu");
            Console.WriteLine("\n\t1 - Center Line. One turn 1$\n\t2 - All horizontal lines. One turn 3$\n\t3 - All vertical lines. One turn 3$\n\t4 - Diagonals. One turn 2$");

            int playersChoseOptionToPLay = int.Parse(Console.ReadLine()); // Converting input to int directly, because later it will be used only as int
            // add while loop until the player has money
            // 3. Create 2D array for random numbers.

            Random randomNumbersGenerator = new Random(); // random numbers function
            int[,] array2Dimmensional = new int[3, 3];  // columns and lines of the grid
            
            for (int rows = 0; rows < 3; rows++) //populating 2D Array. for every row for loop adding three columns and random numbers to it
            {
                for (int columns = 0; columns < 3; columns++) 
                {
                    array2Dimmensional[rows, columns] = randomNumbersGenerator.Next(0, 1); // attributing random numbers to every row and column
                }
            }

            // 4. Create and output Random Numbers machine (slot machine).

            for (int rows = 0; rows < array2Dimmensional.GetLength(0); rows++) // getting the length of rows and columns from array2Dimmensional = new int[3, 3];
                                                                               // GetLength(0) means first number in 2 dimensional array like in here is "3"
                                                                               // GetLength(1) means second number in 2 dimensional array like in here is "3"
            {
                for (int columns = 0; columns < array2Dimmensional.GetLength(1); columns++)
                {
                    Console.Write($" {array2Dimmensional[rows, columns]}");
                }
                Console.WriteLine();
            }

            // 5. Create if statements to see if he wants to play combination of (vertical lines, horizontal lines, only center line, two horizontal lines...)
            // variables for booleans
 
            int fColFLine = array2Dimmensional[0, 0];
            int sColFLine = array2Dimmensional[0, 1];
            int tColFLine = array2Dimmensional[0, 2];
            int fColSLine = array2Dimmensional[1, 0];
            int sColSLine = array2Dimmensional[1, 1];
            int tColSLine = array2Dimmensional[1, 2];
            int fColTLine = array2Dimmensional[2, 0];
            int sColTLine = array2Dimmensional[2, 1];
            int tColTLine = array2Dimmensional[2, 2];

            // boolean for if statements

            bool firstLine = fColFLine == sColFLine && sColFLine == tColFLine;
            bool secondLine = fColSLine == sColSLine && sColSLine == tColSLine;
            bool thirdLine = fColTLine == sColTLine && sColTLine == tColTLine;

            if (playersChoseOptionToPLay == 1) // only center line
            {
                if(secondLine)
                {
                    Console.WriteLine("You won!!!");
                    // add money to players balance
                }
                Console.WriteLine("You lost");
                // Take out from players balance

            }

            if (playersChoseOptionToPLay == 2)
            {
                if (firstLine && secondLine && thirdLine)
                {
                    Console.WriteLine("You won 3 dollars!!!");
                    // add money to players balance
                }
                else if (firstLine && secondLine | firstLine && thirdLine | secondLine && thirdLine)
                {
                    Console.WriteLine("You won 2 dollars !!!");
                    // add money to players balance
                }
                else if (firstLine | secondLine | thirdLine)
                {
                    Console.WriteLine("You won 1 dollar!!!");
                    // add money to players balance
                }else
                              
                    Console.WriteLine("You lost");
                // Take out from players balance
            }

            if (playersChoseOptionToPLay == 3)
            {

            }

            if (playersChoseOptionToPLay == 4)
            {

            }


            // 7. Check if player win or lose.










            // 8. Show how much money has player always, add winning, take out if lose.

        }
    }
}