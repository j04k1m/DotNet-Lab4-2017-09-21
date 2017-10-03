using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{

    class EmptySquar : Squar
    {

        public EmptySquar()
        {
            this.MapChar = ' ';
            this.MapColor = ConsoleColor.White;
            this.TypAvSquar = TyperAvSquarse.EmptySquare;
            this.CanMoveOnSquare = true;
        }
    }
}
