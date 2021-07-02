using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Game
{
    class Game
    {
        static void swap(int button, int[] s)
        {
            int move, temp, position, shift = 0;
            position = Array.IndexOf(s, 1);
            move = position;
            switch (button)
            {
                case 2:
                    shift = +6;
                    break;
                case 8:
                    shift = -6;
                    break;
                case 4:
                    shift = -1;
                    break;
                case 6:
                    shift = +1;
                    break;
            }
            temp = s[move];
            s[move] = s[move + shift];
            s[move + shift] = temp;
        }
        static void game(int[] g)
        {
            output(g);
            Console.WriteLine("Use arrow key to move element");
            Console.WriteLine("        8(up)            ");
            Console.WriteLine("4(Left)        6(Right)");
            Console.WriteLine("        2(Down)          ");

            int button;
            while (true)
            {
                Console.Write("Move towards :");
                button = int.Parse(Console.ReadLine());
                int position;
                if (button == 2 || button == 4 || button == 6 || button == 8)
                {
                    position = Array.IndexOf(g, 1);
                    if (position == 0 || position == 4 || position == 24 || position == 28)
                    {
                        if (position == 0)
                        {
                            switch (button)
                            {
                                case 6:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved right");
                                    break;
                                case 2:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved down");
                                    break;
                                case 4:
                                    Console.WriteLine("you cant move left");
                                    break;
                                case 8:
                                    Console.WriteLine("you cant move up");
                                    break;
                            }
                        }
                        else if (position == 4)
                        {
                            switch (button)
                            {
                                case 2:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved down");
                                    break;
                                case 4:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved left");
                                    break;
                                case 6:
                                    Console.WriteLine("you cant move right");
                                    break;
                                case 8:
                                    Console.WriteLine("you cant move up ");
                                    break;

                            }

                        }
                        else if (position == 24)
                        {
                            switch (button)
                            {
                                case 6:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved right");
                                    break;
                                case 8:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved up");
                                    break;
                                case 2:
                                    Console.WriteLine("you cant move down");
                                    break;
                                case 4:
                                    Console.WriteLine("you cant move left");
                                    break;
                            }


                        }
                        else
                        {
                            switch (button)
                            {
                                case 4:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved left");
                                    break;
                                case 8:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved up");
                                    break;
                                case 6:
                                    Console.WriteLine("you cant move right ");
                                    break;
                                case 2:
                                    Console.WriteLine("you cant move down ");
                                    break;
                            }

                        }
                    }
                    else if (position == 1 || position == 2 || position == 3 || position == 25 || position == 26 || position == 27)
                    {
                        if (position == 1 || position == 2 || position == 3)
                        {

                            switch (button)
                            {
                                case 6:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved right");
                                    break;
                                case 2:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved down");
                                    break;
                                case 4:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved left");
                                    break;
                                case 8:
                                    Console.WriteLine("you cant move up");
                                    break;
                            }
                        }
                        else if (position == 25 || position == 26 || position == 27)
                        {
                            switch (button)
                            {
                                case 4:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved left");
                                    break;
                                case 6:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved right");
                                    break;
                                case 8:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved up");
                                    break;
                                case 2:
                                    Console.WriteLine("you cant move down");
                                    break;
                            }

                        }

                    }
                    else if (position == 6 || position == 12 || position == 18 || position == 10 || position == 16 || position == 22)
                    {
                        if (position == 6 || position == 12 || position == 18)
                        {
                            switch (button)
                            {
                                case 2:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved down");
                                    break;
                                case 8:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved up");
                                    break;
                                case 6:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved right");
                                    break;
                                case 4:
                                    Console.WriteLine("you cant move left");
                                    break;
                            }
                        }
                        else
                        {
                            switch (button)
                            {
                                case 2:

                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved down");
                                    break;
                                case 4:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved left");
                                    break;
                                case 8:
                                    swap(button, g);
                                    output(g);
                                    Console.WriteLine("you moved up");
                                    break;
                                case 6:
                                    Console.WriteLine("you cant move right");
                                    break;
                            }

                        }
                    }
                    else
                    {
                        switch (button)
                        {
                            case 6:
                                swap(button, g);
                                output(g);
                                Console.WriteLine("you moved right");
                                break;
                            case 2:
                                swap(button, g);
                                output(g);
                                Console.WriteLine("you moved down");
                                break;
                            case 8:

                                swap(button, g);
                                output(g);
                                Console.WriteLine("you moved up");
                                break;
                            case 4:
                                swap(button, g);
                                output(g);
                                Console.WriteLine("you moved left");
                                break;
                        }

                    }
                   // output(g);
                }
                else if (button == 123)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("enter the valid input");
                }
            }
        }
        static void output(int[] op)
        {
            int value = 0;

            for (int i = 0; i < op.Length; i++)
            {
                if (value < 5)
                {

                    Console.Write(op[i] + "\t");
                    value++;
                }
                else
                {
                    Console.WriteLine("");
                    value = 0;
                }
            }
        }
        static void Main(string[] args)
        {
            int array_size = 30;
            int[] grid = new int[array_size];

            for (int i = 0; i < grid.Length; i++)
            {
                if (i == 0)
                    grid[0] = 1;
                else
                    grid[i] = 0;
            }

            game(grid);
        }
    }
}
