using System;
using System.Collections.Generic;

namespace OOP_Assignment_2
{
    public class Statistics
    {
        // Dictionarty so statistics can be stored for each game type
        private Dictionary<string, GameStatistics> gameStatistics = new Dictionary<string, GameStatistics>();

        public void UpdateStatistics(string gameType, int plays, int highScore)
        {
            if (!gameStatistics.ContainsKey(gameType))
            {
                gameStatistics.Add(gameType, new GameStatistics());
            }

            gameStatistics[gameType].TotalPlays += plays;
            if (highScore > gameStatistics[gameType].HighScore)
            {
                gameStatistics[gameType].HighScore = highScore;
            }
        }

        public void ViewStatistics()
        {
            Console.WriteLine("Viewing game statistics:");

            foreach (var kvp in gameStatistics)
            {
                Console.WriteLine($"Game Type: {kvp.Key}");
                Console.WriteLine($"Total Plays: {kvp.Value.TotalPlays}");
                Console.WriteLine($"High Score: {kvp.Value.HighScore}");
                Console.WriteLine();
            }
        }
    }

    // Stats for each game type:
    public class GameStatistics
    {
        public int TotalPlays { get; set; } = 0;
        public int HighScore { get; set; } = 0;
    }
}