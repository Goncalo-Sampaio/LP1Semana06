using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerStats
{
    public class Player
    {
        private float highScore;
        private int playedGames;
        private int wonGames;
        public string Name { get; }

        public float HighScore
        {
            get => highScore;
            set
            {
                if (value > highScore)
                {
                    highScore = value;
                }
            }
        }

        public int WinRate
        {
            get
            {
                if (playedGames > 0)
                {
                    return 0;
                }
                else
                {
                    return wonGames / playedGames;
                }
            }
        }

        public Player(string name){
            Name = name;
            HighScore = 0;
            wonGames = 0;
            playedGames = 0;
        }

         public void PlayGame(bool win){
            playedGames++;
            if (win){
                wonGames++;
            }
         }
    }
}