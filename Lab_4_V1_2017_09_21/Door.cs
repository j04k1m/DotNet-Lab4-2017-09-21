using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{

    class Door : Squar
    {
        public Door()
        {
            this.MapChar = 'D';
            this.MapColor = ConsoleColor.Red;
            this.TypAvSquar = TyperAvSquarse.Door;
            this.CanMoveOnSquare = false;
        }



    }
}
