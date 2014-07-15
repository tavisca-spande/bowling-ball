using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling
{
    public class Game
    {
        int [] rolls = new int[25];
        public int score = 0;
        public int rollpointer = 0;
        public void Roll(int pins)
        {
            rolls[rollpointer++]=pins;
            if (pins == 10)
            {
                rolls[rollpointer++] = 0; 
            }
           
        }

        public int GetScore()
        {
            int iterator = 0;
            for (iterator = 0; iterator < 20; iterator++)
            {
                score += rolls[iterator];
                if (iterator % 2 == 0 && rolls[iterator] == 10 && rolls[iterator + 2] == 10) // consecutive strikes
                    score += rolls[iterator + 2] + rolls[iterator + 4];
                else if (iterator % 2 == 0 && rolls[iterator] == 10)        //counting the bonus for strike
                    score += rolls[iterator + 2] + rolls[iterator + 3];
                else if (iterator % 2 == 0 && (rolls[iterator] + rolls[iterator + 1]) == 10) //condition for spare
                    score += rolls[iterator + 2];                
            }
            return score;
        }


       

    }
}
