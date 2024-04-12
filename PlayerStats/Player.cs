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
    }
}