using snack_2;
using System;
using System.Globalization;


namespace MyApp // Note: actual namespace depends on the project name.
{

    internal class Program
    {



        static void Main(string[] args)
        {
            int newGame = 1, z = 0;


            while (newGame < 9)
            {
                Functions myFuncs = new Functions();
                PrintShape printShape = new PrintShape();
                Console.Clear();
                bool flag = true;
                myFuncs.PrintBoard();
                Console.WriteLine($"your level is:{newGame} your score is:{myFuncs.CounterMove}");
                Console.SetWindowSize(81, 26);
                myFuncs.CounterMove = z;
                Random rnd = new();
                for (int i = 0; i < newGame + 3; i++)
                {
                    switch (rnd.Next(0, 4))
                    {
                        case 0:
                            // printShape.PrintRectangle(myFuncs.array);
                            break;
                        case 1:
                            printShape.PrintSqr(myFuncs.array);
                            break;
                        case 2:
                            printShape.PrintLine(myFuncs.array);
                            break;
                        case 3:
                            printShape.Printtriangular1(myFuncs.array);
                            break;
                    }
                }

                Console.SetCursorPosition(myFuncs.xValue, myFuncs.yValue);

              


                while (flag == true)
                {
                    var key = Console.ReadKey();
                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            myFuncs.CheckMoveUp();
                            myFuncs.MoveUp();
                            break;
                        case ConsoleKey.DownArrow:
                            myFuncs.CheckMoveDown();
                            myFuncs.MoveDown();
                            break;
                        case ConsoleKey.RightArrow:
                            myFuncs.CheckMoveRight();
                            myFuncs.MoveRight();
                            break;
                        case ConsoleKey.LeftArrow:
                            myFuncs.CheckMoveLeft();
                            myFuncs.MoveLeft();
                            break;
                    }
                    myFuncs.CheckGame(ref flag);
                    myFuncs.ClearCurrentConsoleLine();
                    Console.WriteLine($"your level is:{newGame} your score is:{myFuncs.CounterMove}");
                }
                newGame++;
                    z = myFuncs.CounterMove;
                }
                Console.Clear();
                Console.WriteLine("Game over");

            }
        }
    }

