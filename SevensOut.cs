using System;

namespace OOP_Assignment_2
{
    public class SevensOut
    {
        // This is the winning number for the game total, first player to it wins
        private const int WinningNumber = 20;
        private static int highScore = 0; // Add a high score tracker

        public static int HighScore { get { return highScore; } }

        public static void Play()
        {
            Console.WriteLine("Welcome to Sevens Out!");
            Console.WriteLine($"Achieve the following winning number to win the game!: {WinningNumber}");

            int player1Score = 0;
            int player2Score = 0;
            Random random = new Random();
            int currentPlayer = 1;

            while (true)
            {
                int roll1 = random.Next(1, 7); // Rolls a dice for player 1
                int roll2 = random.Next(1, 7); // Rolls a dice for player 2
                int totalRoll = roll1 + roll2;
                Console.WriteLine($"Player {currentPlayer} rolled: {roll1} and {roll2}. Total number from two rolls is: {totalRoll}");

                // Once a 7 is rolled, this code will delcare winner and end the game
                if (totalRoll == 7)
                {
                    Console.WriteLine($"A seven has been totalled! {currentPlayer} loses!");
                    break;
                }
                else
                {
                    int scoreToAdd = totalRoll;
                    if (roll1 == roll2)
                    {
                        scoreToAdd *= 2; // Double the score if it's a double [RULE]
                        Console.WriteLine($"A double has been rolled! Adding the double to the total score!: {scoreToAdd}");
                    }

                    if (currentPlayer == 1)
                    {
                        player1Score += scoreToAdd;
                        Console.WriteLine($"Player 1's current score: {player1Score}");
                        if (player1Score > highScore)
                        {
                            highScore = player1Score; // Update high score if player 1's score is higher
                        }
                    }
                    else
                    {
                        player2Score += scoreToAdd;
                        Console.WriteLine($"Player 2's current score: {player2Score}");
                        if (player2Score > highScore)
                        {
                            highScore = player2Score; // Update high score if player 2's score is higher
                        }
                    }

                    if (player1Score >= WinningNumber)
                    {
                        Console.WriteLine("Congratulations! Player 1 wins!");
                        break;
                    }
                    else if (player2Score >= WinningNumber)
                    {
                        Console.WriteLine("Congratulations! Player 2 wins!");
                        break;
                    }
                }

            }
        }
    }
}