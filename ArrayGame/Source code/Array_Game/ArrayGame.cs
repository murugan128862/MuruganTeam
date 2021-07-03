using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Game
{
    class ArrayGame
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1.Start"+"\n"+"2.Exit");
            Console.Write("Enter the option : ");
            int input = int.Parse(Console.ReadLine());
            if (input == 2)
                System.Environment.Exit(0);
            else
            {
                Console.Write("Enter the size of the grid : ");
                int grid_size = int.Parse(Console.ReadLine());
                int[] grid = new int[grid_size * grid_size];
                for (int i = 0; i < grid.Length; i++)
                {
                    if (i == 0)
                    {
                        grid[0] = 1;
                    }
                    else
                        grid[i] = 0;
                }
                output(grid, grid_size);
                game(grid, grid_size);
            }
        }
        static void output(int[] grid,int size)
        {
            int value = size;
            for(int i = 0; i < grid.Length; i++)
            {
                if (i >= size)
                {
                    Console.WriteLine();
                    size += value;
                }
                Console.Write(grid[i]+"\t");
            }
            Console.WriteLine();
        }
        static void shift(int [] grid,int size,int button)
        {
            int position = Array.IndexOf(grid, 1);
            int move=size,temp,shift=0;
            switch (button)
            {
                case 2:
                    temp = grid[position];
                    grid[position] = grid[position + size];
                    grid[position + size] = temp;
                    break;
                case 4:
                    temp = grid[position];
                    grid[position] = grid[position -1];
                    grid[position -1] = temp;
                    break;
                case 6:
                    temp = grid[position];
                    grid[position] = grid[position + 1];
                    grid[position + 1] = temp;
                    break;
                case 8:
                    temp = grid[position];
                    grid[position] = grid[position - size];
                    grid[position - size] = temp;
                    break;
            }     
        }
        static void game(int[] grid,int size)
        {
            while(true)
            {
                Console.WriteLine("____________________________________________________________________________");
                Console.Write("Move towards : ");
                int button = int.Parse(Console.ReadLine());
                int position = Array.IndexOf(grid, 1);
                switch (button)
                {
                    case 1:
                        System.Environment.Exit(0);
                        break;
                    case 2:
                        if(position>=grid.Length-size && position<grid.Length )
                        {
                            Console.WriteLine("Cant move down");
                           
                        }
                        else
                        {
                            shift(grid, size, button);
                            output(grid, size);
                        }
                        break;
                    case 4:
                        if (position <= 0 || position % size==0)
                            Console.WriteLine("Cant move left");
                        else
                        {
                            shift(grid, size, button);
                            output(grid, size);
                        }
                        break;
                    case 6:
                        position++;
                        if (position % size == 0)
                            Console.WriteLine("cant move right");
                        else
                        {
                            shift(grid, size, button);
                            output(grid, size);
                        }
                        break;
                    case 8:
                        if (position >= 0 && position < size)
                            Console.WriteLine("cant move up");
                        else
                        {
                            shift(grid, size, button);
                            output(grid, size); 
                        }
                        break;
                    default:
                        Console.WriteLine("Enter the valid input");
                        break;
                }               
            }           
        }
    }
}
