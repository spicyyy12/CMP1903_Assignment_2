using System;

namespace OOP_Assignment_2
{
    public class Program
    {
        private static Statistics statistics = new Statistics(); // Create instance of Statistics class

        static void Main(string[] args)
        {
            MainMenu();
        }

        static void MainMenu()
        {
            Console.WriteLine("Welcome to the main menu, please select what you would like to do!");
            Console.WriteLine("1. Play Sevens Out!");
            Console.WriteLine("2. Play Three or More");
            Console.WriteLine("3. View statistics data");
            Console.WriteLine("4. Run tests");
            Console.WriteLine("5. Exit menu.");

            Console.Write("Enter your choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    InstantiateSevensOutGame();
                    break;
                case 2:
                    InstantiateThreeOrMoreGame();
                    break;
                case 3:
                    statistics.ViewStatistics(); // Call ViewStatistics method from Statistics class
                    break;
                case 4:
                    SevensOutTests.RunTests();
                    ThreeOrMoreTests.RunTests();
                    break;
                case 5:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("This is not a valid number, please try another input.");
                    break;
            }
            MainMenu();
        }

        static void InstantiateSevensOutGame()
        {
            // Plays the sevens out game once selected by the user
            Console.WriteLine("Now playing Sevens Out!");
            SevensOut.Play();

            // Update statistics after playing
            statistics.UpdateStatistics("Sevens Out", 1, SevensOut.HighScore);
        }

        static void InstantiateThreeOrMoreGame()
        {
            // Plays the three or more game once selected by the user
            Console.WriteLine("Now playing Three or More!");
            ThreeOrMore.Play();

            // Update statistics after playing
            statistics.UpdateStatistics("Three or More", 1, ThreeOrMore.HighScore);
        }
    }
}