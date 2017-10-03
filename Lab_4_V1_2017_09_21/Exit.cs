using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{
    class Exit : Squar
    {
        public static bool hasReachedExit = false;

        public Exit()
        {
            this.MapChar = 'E';
            this.MapColor = ConsoleColor.Yellow;
            this.TypAvSquar = TyperAvSquarse.Exit;
            this.CanMoveOnSquare = true;
        }


    }
}
