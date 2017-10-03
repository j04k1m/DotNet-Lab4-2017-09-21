using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{
    class Squar
    {
        public enum TyperAvSquarse
        {
            Wall,
            Door,
            Key,
            Player,
            Monster,
            Exit,
            Room,
            EmptySquare
        }



        public TyperAvSquarse TypAvSquar { get; set; }
        public Boolean CanMoveOnSquare { get; set; }

        public Char MapChar { get; set; }
        public ConsoleColor MapColor { get; set; }
    }
}
