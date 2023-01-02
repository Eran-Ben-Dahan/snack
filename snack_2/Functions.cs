using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace snack_2
{
    public partial class Functions : Component
    {
        public int col = 80, row = 25;
        public char[,] array = new char[26, 81];//the array


        public void PrintBoard()//print the basic board with limits
        {

            for (int i = 0; i < 26; i++)
            {
                for (int j = 0; j < 81; j++)
                {
                    array[i, j] = ' ';
                }
            }

            for (int i = 0; i < 26; i++)
            {

                array[i, 0] = '+';
                array[i, 80] = '+';


                for (int j = 0; j < 81; j++)
                {

                    array[0, j] = '+';
                    array[25, j] = '+';
                    Console.Write(array[i, j]);

                }
                Console.WriteLine();
            }

        }

        public int xValue, loss = 0, yValue;
       
        public int CounterMove { get; set; }


        public Functions(int counterMove)
        {
            CounterMove = counterMove;

        }
        public Functions()
        {

            Random rnd = new Random();

            xValue = rnd.Next(1, 81);
            yValue = rnd.Next(1, 26);
           

        }
        public void ClearCurrentConsoleLine()
        {
            Console.SetCursorPosition(0, 26);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
        public void CheckGame(ref bool flag)
        {
            if (loss > 0)
            {
                Console.Clear();
                flag = false;

            }
            if (loss == 10)
            {
                Console.WriteLine("game over");
            }
        }
        public void MoveUp()
        {
            if (yValue <= 1)
            {
                yValue = 1;
            }
            else
            {
                array[yValue, xValue] = '*';
                Console.SetCursorPosition(xValue, yValue);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
                yValue--;
                CounterMove++;
            }

            Console.SetCursorPosition(xValue, yValue);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("*");
            array[yValue, xValue] = '*';
        }
        public void CheckMoveUp()
        {
            if (array[yValue - 1, xValue] != ' ' && (array[yValue - 1, xValue] != '+'))
            {
                loss++;
            }
        }
        public void CheckMoveDown()
        {
            if (array[yValue + 1, xValue] != ' ' && array[yValue + 1, xValue] != '+')
            {
                loss++;
            }
        }
        public void MoveDown()
        {
            if (yValue >= 24)
            {
                yValue = 24;
            }
            else
            {
                array[yValue, xValue] = '*';
                Console.SetCursorPosition(xValue, yValue);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
                yValue++;
                CounterMove++;
            }
            Console.SetCursorPosition(xValue, yValue);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("*");
            array[yValue, xValue] = '*';
        }
        public void CheckMoveRight()
        {
            if (array[yValue, xValue + 1] != ' ' && array[yValue, xValue + 1] != '+')
            {
                loss++;
            }
        }
        public void MoveRight()
        {
            if (xValue >= 79)
            {
                xValue = 79;
            }
            else
            {
                array[yValue, xValue] = '*';
                Console.SetCursorPosition(xValue, yValue);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
                xValue++;
                CounterMove++;
            }

            Console.SetCursorPosition(xValue, yValue);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("*");
            array[yValue, xValue] = '*';
        }
        public void CheckMoveLeft()
        {
            if (array[yValue, xValue - 1] != ' ' && array[yValue, xValue - 1] != '+')
            {
                loss++;
            }
        }
        public void MoveLeft()
        {
            if (xValue == 1)
            {
                xValue = 1;

            }
            else
            {
                array[yValue, xValue] = '*';
                Console.SetCursorPosition(xValue, yValue);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("*");
                xValue--;
                CounterMove++;
            }

            Console.SetCursorPosition(xValue, yValue);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("*");
            array[yValue, xValue] = '*';
        }

    }
}

