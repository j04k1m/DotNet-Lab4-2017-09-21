using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4_V1_2017_09_21
{
    class Program
    {


        const int defultCurserPos_X = 0;
        const int defultCurserPos_Y = 5;


        static void Main(string[] args)
        {

            Map.Draw_Map();



            do
            {

                
                ConsoleKeyInfo player_Key_Input = Console.ReadKey();


                // Kollar vilken knapp som trycktes
                // Om någon av arrows så ser den om kan flytta till
                // nya x och y och om går flyttar
                if (player_Key_Input.Key == ConsoleKey.UpArrow)
                {
                    if (Map.CanPlayerMove(Player.player_Pos_X, Player.player_Pos_Y - 1))
                    {
                        Map.Move_Player(Player.player_Pos_X, Player.player_Pos_Y, Player.player_Pos_X, Player.player_Pos_Y - 1);
                        Player.player_Pos_Y--;
                    }
                }
                else if (player_Key_Input.Key == ConsoleKey.RightArrow)
                {
                    if (Map.CanPlayerMove(Player.player_Pos_X + 1, Player.player_Pos_Y))
                    {
                        Map.Move_Player(Player.player_Pos_X, Player.player_Pos_Y, Player.player_Pos_X + 1, Player.player_Pos_Y);
                        Player.player_Pos_X++;
                    }

                }
                else if (player_Key_Input.Key == ConsoleKey.DownArrow)
                { 
                    if (Map.CanPlayerMove(Player.player_Pos_X, Player.player_Pos_Y + 1))
                    {

                        Map.Move_Player(Player.player_Pos_X, Player.player_Pos_Y, Player.player_Pos_X, Player.player_Pos_Y + 1);
                        Player.player_Pos_Y++;
                    }
                }
                else if (player_Key_Input.Key == ConsoleKey.LeftArrow)
                {
                    if (Map.CanPlayerMove(Player.player_Pos_X - 1, Player.player_Pos_Y))
                    {

                        Map.Move_Player(Player.player_Pos_X, Player.player_Pos_Y, Player.player_Pos_X - 1, Player.player_Pos_Y);
                        Player.player_Pos_X--;
                    }
                }

                MoveCurserToDefultePos();




            } while (!Exit.hasReachedExit);

            Console.WriteLine("The End");
            Console.WriteLine("The End");
            Console.WriteLine("The End");
            Console.ReadLine();
        }

        static void MoveCurserToDefultePos()
        {
            Console.SetCursorPosition(defultCurserPos_X, defultCurserPos_Y);
            Console.Write(" ");
            Console.SetCursorPosition(defultCurserPos_X, defultCurserPos_Y);
        }

    }
}
