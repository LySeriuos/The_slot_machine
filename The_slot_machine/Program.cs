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

            // 3. Create multi- random numbers.
            Console.WriteLine("randomNumbers");

            Random randomNumbersGenerator = new Random();

            for (int randomNumbersInArray = 0; randomNumbersInArray < 100; randomNumbersInArray++)
            {
                Console.WriteLine(randomNumbersGenerator.Next(10)); //returns random integers(numbers) < 10
            }






            // 4. Create 2D arrays for random numbers.
            Console.WriteLine("2D array");


            int[,] arr2d = new int[3, 3]{
                                {1, 2, 3},
                                {4, 5, 6},
                                {7, 8, 9}
                            };
            Console.WriteLine(arr2d[0, 0]);
            Console.WriteLine(arr2d[0, 1]);
            Console.WriteLine(arr2d[0, 2]);
            Console.WriteLine(arr2d[1, 0]);
            Console.WriteLine(arr2d[1, 1]);
            Console.WriteLine(arr2d[1, 2]);
            Console.WriteLine(arr2d[2, 0]);
            Console.WriteLine(arr2d[2, 1]);
            Console.WriteLine(arr2d[2, 2]);






            // 5. Create Random Numbers machine (slot machine).













            // 6. Create if statements for every combination.












            // 7. Check if player win or lose.










            // 8. Show how much money has player always, add winning, take out if lose.

        }
    }
}