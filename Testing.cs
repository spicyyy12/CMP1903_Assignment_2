using System;
using System.Diagnostics;

namespace OOP_Assignment_2
{
    // SEVENS OUT TESTS
    public class SevensOutTests
    {
        public static void RunTests()
        {
            Console.WriteLine("Running Sevens Out tests...");

            // Creates a game
            Game game = new Game();

            // adds values to the tested game only
            game.AddValue(2);
            game.AddValue(3);
            game.AddValue(2);

            Console.WriteLine("Sevens Out tests completed.");
        }
    }

    // THREE OR MORE TESTS
    public class ThreeOrMoreTests
    {
        public static void RunTests()
        {
            Console.WriteLine("Running Three or More tests...");

            // Creates a game
            Game game = new Game();

            // Adds the scores to the tested game only
            game.AddScore(10);
            game.AddScore(7);
            game.AddScore(5);

            // is the total score equal to 20?
            Debug.Assert(game.TotalScore() >= 20, "Three Or More test failed: Total score less than 20.");

            Console.WriteLine("Three or More tests completed.");
        }
    }

    // Class for the testing of the games above
    public class Game
    {
        private int totalScore;
        private int totalValue;

        public void AddScore(int score)
        {
            totalScore += score;
        }

        public void AddValue(int value)
        {
            totalValue += value;
        }

        public int TotalScore()
        {
            return totalScore;
        }

        public int TotalValue()
        {
            return totalValue;
        }
    }
}