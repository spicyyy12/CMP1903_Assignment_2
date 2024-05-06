using System;

namespace OOP_Assignment_2
{
    public class ThreeOrMore
    {
        private static int highScore = 0; // Add a high score tracker

        public static int HighScore { get { return highScore; } }

        public static void Play()
        {
            Console.WriteLine("Welcome to the Three or More game!");
            Console.WriteLine("Roll five dice and try to get a 3-of-a-kind or better to reach a total of 20 or more.");

            Random random = new Random();

            int totalScore = 0;

            while (totalScore < 20)
            {
                int[] dice = new int[5];

                for (int i = 0; i < 5; i++)
                {
                    dice[i] = random.Next(1, 7); // Rolls a dice (1-6)
                    Console.WriteLine($"Dice {i + 1}: {dice[i]}");
                }

                Array.Sort(dice);

                int count = 1;
                int maxCount = 1;
                int prevDie = dice[0];

                for (int i = 1; i < 5; i++)
                {
                    if (dice[i] == prevDie) // Dice check to see if previous roll is equal to current roll
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                        }
                    }
                    else
                    {
                        //Reset count if die value is different
                        count = 1;
                    }
                    prevDie = dice[i];
                }

                int scoreToAdd = 0;
                switch (maxCount)
                {
                    //sets the scores for what points need to be given to the user
                    case 3:
                        scoreToAdd = 3;
                        break;
                    case 4:
                        scoreToAdd = 6;
                        break;
                    case 5:
                        scoreToAdd = 12;
                        break;
                }

                totalScore += scoreToAdd;
                Console.WriteLine($"Your total score: {totalScore}");

                if (maxCount >= 3 && totalScore >= 20)
                {
                    Console.WriteLine("Congratulations! You win Three or more!");
                    if (totalScore > highScore)
                    {
                        highScore = totalScore; // Update high score if current score is higher
                    }
                    break;
                }
                else if (totalScore < 20)
                {
                    Console.WriteLine("You didn't reach a 3-of-a-kind or better, or your total score is less than 20. Would you like to roll again? (y / n)");
                    string choice = Console.ReadLine();
                    if (choice.ToLower() != "y") //if "y" not input, dont roll
                        break;
                }
            }

            if (totalScore < 20)
            {
                Console.WriteLine("You didn't reach a score of 20, better luck next time!");
            }
        }
    }
}