using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{
    class Player : Squar
    {

        public Player()
        {
            this.MapChar = 'o';
            this.MapColor = ConsoleColor.Green;
            this.TypAvSquar = TyperAvSquarse.Player;
            this.CanMoveOnSquare = true;

        }

        public static int player_Pos_X = 1;
        public static int player_Pos_Y = 1;

        public static int playerNummberOfMovesDone = 0;
        public static int PlayerNummberOfKeys { get; set; }

    }
}
