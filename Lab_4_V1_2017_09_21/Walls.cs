using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{

    class Walls : Squar
    {
        public Walls()
        {
            this.MapChar = '#';
            this.MapColor = ConsoleColor.White;
            this.TypAvSquar = TyperAvSquarse.Wall;
            this.CanMoveOnSquare = false;
        }
    }
}