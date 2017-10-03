using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{
    class Highscore
    {
        

        public void HighscoreArray()
        {
            int[] HighscoreArray = new int[5];

            for (int i = 0; i > 5; i++)
            {
                HighscoreArray[i] = Player.playerNummberOfMovesDone;
                

            }

            Console.WriteLine(HighscoreArray[1]);
        }
    }
}
