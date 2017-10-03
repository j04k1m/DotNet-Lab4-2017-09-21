using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{

    class Room : Squar
    {
        public Room()
        {
            this.MapChar = 'R';
            this.MapColor = ConsoleColor.Cyan;
            this.TypAvSquar = TyperAvSquarse.Room;
            this.CanMoveOnSquare = true;
        }
    }
}
