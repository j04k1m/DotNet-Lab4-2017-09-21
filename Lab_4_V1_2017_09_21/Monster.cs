using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{

    class Monster : Squar
    {

        public static int costIfMoveOnMonster = 3;

        public Monster()
        {
            this.MapChar = 'M';
            this.MapColor = ConsoleColor.Red;
            this.TypAvSquar = TyperAvSquarse.Monster;
            this.CanMoveOnSquare = true;
        }


    }
}
