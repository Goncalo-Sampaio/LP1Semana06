using System;

namespace PlayerStats
{
    public class Program
    {
        private static void Main()
        {
            Player[] players = {
                new Player("Ana"),
                new Player("Zé"),
                new Player("Doesn't play")
            };

            players[0].PlayGame(false);
            players[0].PlayGame(true);
            players[0].PlayGame(true);
            players[0].PlayGame(false);
            players[0].PlayGame(false);
            players[0].PlayGame(true);
            players[0].HighScore = 123;
            players[0].HighScore = 40;

            players[1].PlayGame(true);
            players[1].PlayGame(true);
            players[1].HighScore = 12;
            players[1].HighScore = 67;
            players[1].HighScore = 91;
            players[1].HighScore = 32;

            foreach (Player player in players)
            {
                Console.WriteLine($" Player name : {player.Name}");
                Console.WriteLine($"    Win rate : {player.WinRate}");
                Console.WriteLine($"  High score : {player.HighScore}");
                Console.WriteLine("--------------------------------");
            }

            // Output deve ser:
            //
            //  Player name : Ana
            //     Win rate : 0.5
            //   High score : 123
            // --------------------------------
            //  Player name : Zé
            //     Win rate : 1
            //   High score : 91
            // --------------------------------
            //  Player name : Doesn't play
            //     Win rate : 0
            //   High score : 0
            // --------------------------------

        }
    }
}
