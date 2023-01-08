using System;

namespace The_slot_machine // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

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
            // 2.1 Create if statements to see if he wants to play combination of (vertical lines, horizontal lines, only center line, two horizontal lines...)
            Console.WriteLine("Add your amount of game money in USD $");
            int playersGameMoney = int.Parse(Console.ReadLine()); // Converting input to int directly, because later it will be used only as int
            Console.WriteLine("Choose how many lines you will play by typing in number of the menu");
            Console.WriteLine("\n\t1 - Center Line. One turn 1$\n\t2 - All horizontal lines. One turn 3$\n\t3 - All vertical lines. One turn 3$\n\t4 - Diagonals. One turn 2$");
            int playersChoseOptionToPLay = int.Parse(Console.ReadLine()); // Converting input to int directly, because later it will be used only as int
            if (playersChoseOptionToPLay == 1)
            {

            }

            if (playersChoseOptionToPLay == 2)
            {

            }

            if (playersChoseOptionToPLay == 3)
            {

            }

            if (playersChoseOptionToPLay == 4)
            {

            }

            // 3. Create multi-dimensional random numbers.
            Console.WriteLine("randomNumbers");

            Random randomNumbersGenerator = new Random(); // random numbers function
            int[,] array2Dimmensional = new int[3, 3];  // columns and lines of the grid

            
            for (int rows = 0; rows < 3; rows++) //populating 2D Array. for every row for loop adding three columns and random numbers to it
            {
                for (int columns = 0; columns < 3; columns++) 
                {
                    array2Dimmensional[rows, columns] = randomNumbersGenerator.Next(0, 10); // attributing random numbers to every row and column
                }
            }

            
          






            // 4. Create 2D arrays for random numbers.
            Console.WriteLine("2D array");


            
        






            // 5. Create Random Numbers machine (slot machine).













            // 6. Create if statements for every combination.












            // 7. Check if player win or lose.










            // 8. Show how much money has player always, add winning, take out if lose.

        }
    }
}