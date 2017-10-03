using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{
    class Map
    {
        const int padTextToRight = 4;


        static Squar[,] mapArrayObjects = new Squar[,] {
            {
                new Walls(),
                new Walls(),
                new Walls(),
                new Walls(),
                new Walls()
            },
            {
                new Walls(),
                new Player(),
                new EmptySquar(),
                new Monster(),
                new Walls()
            },
            {
                new Walls(),
                new Door(),
                new Key(),
                new Walls(),
                new Walls()
            },
            {
                new Walls(),
                new Exit(),
                new Walls(),
                new Walls(),
                new Walls()
            }
        };


        enum Typer { Key };

        public static void Draw_Map()
        {

            for (int i = 0; i != mapArrayObjects.GetLength(0); i++)
            {
                for (int x = 0; x != mapArrayObjects.GetLength(1); x++)
                {
                    Console.SetCursorPosition(i, x);
                    Console.ForegroundColor = mapArrayObjects[i, x].MapColor;
                    Console.Write(mapArrayObjects[i, x].MapChar);
                }

            }

            Console.SetCursorPosition(mapArrayObjects.GetLength(0) + padTextToRight, 1);
            Console.Write("Keys : {0}", Player.PlayerNummberOfKeys);

            //                                                                       v--- Magic nummber?
            Console.SetCursorPosition(mapArrayObjects.GetLength(0) + padTextToRight, 2);
            Console.Write("Moves Taken : {0}", Player.playerNummberOfMovesDone);


        }

        public static bool CanPlayerMove(int toMoveX, int toMoveY)
        {
            // Bool

            char charOfExpecctedMove = mapArrayObjects[toMoveX, toMoveY].MapChar;


            if (mapArrayObjects[toMoveX, toMoveY].TypAvSquar == Squar.TyperAvSquarse.Door && Player.PlayerNummberOfKeys > 0)
            {
                return true;
            }
            else if (mapArrayObjects[toMoveX, toMoveY].CanMoveOnSquare)
            {
                return true;
            }

            return false;
        }

        public static void Move_Player(int playerPosX, int playerPosY, int toMoveX, int toMoveY)
        {

            Player.playerNummberOfMovesDone++;


            Squar squarToMoveTo = mapArrayObjects[toMoveX, toMoveY];

            mapArrayObjects[toMoveX, toMoveY] = mapArrayObjects[playerPosX, playerPosY]; // Player 
            mapArrayObjects[playerPosX, playerPosY] = new EmptySquar();



            if (squarToMoveTo.TypAvSquar == Squar.TyperAvSquarse.Key)
            {
                Player.PlayerNummberOfKeys++;
            }
            else if (squarToMoveTo.TypAvSquar == Squar.TyperAvSquarse.Door)
            {
                Player.PlayerNummberOfKeys--;
            }
            else if (squarToMoveTo.TypAvSquar == Squar.TyperAvSquarse.Exit)
            {
                Exit.hasReachedExit = true;
            }
            else if (squarToMoveTo.TypAvSquar == Squar.TyperAvSquarse.Monster)
            {
                Player.playerNummberOfMovesDone += Monster.costIfMoveOnMonster;
            }


            Draw_Map();




        }


    }

}
