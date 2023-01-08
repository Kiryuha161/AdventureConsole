using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AdventureConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            bool isOpen = true;
            int userX = 1, userY = 1;

            char[,] map =
            {
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#', },
                { '#', ' ', ' ','#','#','#','#','#','#','#','#','#','#','#','#','#','#', '#'},
                { '#', ' ', ' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', '#'},
                { '#', ' ', ' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', '#'},
                { '#', ' ', ' ','#','#','#','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#', '#'},
                { '#', ' ', ' ',' ',' ',' ','#',' ',' ',' ','#','#','#','#','#',' ','#', '#'},
                { '#', ' ', ' ',' ',' ',' ','#',' ',' ',' ','#','*',' ',' ','#',' ','#', '#'},
                { '#', ' ', ' ',' ',' ',' ',' ','*',' ',' ','#',' ',' ',' ','#',' ','#', '#'},
                { '#', ' ', ' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ','#',' ','#', '#'},
                { '#', ' ', ' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#', '#'},
                { '#', ' ', ' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ','#',' ','#', '#'},
                { '#', ' ', ' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ','#',' ','#', '#'},
                { '#', ' ', '#','#','#','#','#',' ',' ',' ','#',' ',' ',' ','#','#','#', '#'},
                { '#', ' ', '#',' ','+',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ', '#'},
                { '#', ' ', '#',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ',' ',' ', '#'},
                { '#', ' ', '#','#','#','#','#','#','#','#','#',' ',' ',' ','+',' ',' ', '#'},
                { '#', ' ', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#'},
                { '#', ' ', ' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ',' ', '#'},
                { '#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#','#', },
            };

            char[] bag = new char[1];
            char[] tempBag;

            while (isOpen)
            {
                Console.SetCursorPosition(25, 5);
                Console.Write("Сумка: ");
                for (int i = 0; i < bag.Length; i++)
                {
                    
                    Console.Write(" " + bag[i] + " ");
                }

                Console.SetCursorPosition(0, 0);
                for (int i = 0; i < map.GetLength(0); i++)
                {
                   
                    for (int j = 0; j < map.GetLength(1); j++)
                    {  
                        
                                                   
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine();
                }
                Console.SetCursorPosition(userY, userX);
                Console.Write('@');



                Console.SetCursorPosition(0, 20);
                Console.WriteLine("Введите направление: W - вверх, S - вниз, A - вправо, D - влево");
                char userInput = char.Parse(Console.ReadKey().KeyChar.ToString());
                switch (userInput)
                {
                    case 'w':
                        if (map[userX - 1, userY] != '#')
                        {
                            userX -= 1;
                            
                            Console.SetCursorPosition(userY, userX);
                            Console.Write('@');
                        }
                        break;

                    case 's':
                        if (map[userX + 1, userY] != '#')
                        {
                            userX += 1;
                            
                            Console.SetCursorPosition(userY, userX);
                            Console.Write('@');
                        }
                        break;

                    case 'a':
                        if (map[userX, userY - 1] != '#')
                        {
                            userY -= 1;
                           
                            Console.SetCursorPosition(userY, userX);
                            Console.Write('@');
                        }
                        break;

                    case 'd':
                        if (map[userX, userY + 1] != '#')
                        {
                            userY += 1;
                            
                            Console.SetCursorPosition(userY, userX);
                            Console.Write('@');
                        }

                        break;
                }
                if (map[userX, userY] == '+')
                {
                    map[userX, userY] = 'V';
                    tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = '+';
                    bag = tempBag;
                }

                else if (map[userX, userY] == '*')
                {
                    map[userX, userY] = 'W';
                    tempBag = new char[bag.Length + 1];
                    for (int i = 0; i < bag.Length; i++)
                    {
                        tempBag[i] = bag[i];
                    }
                    tempBag[tempBag.Length - 1] = '*';
                    bag = tempBag;
                }
               
            }
        }
    }
}


