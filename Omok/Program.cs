using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 15;
            int[,] pan = new int[size, size];
            int turn = 1;



            while (true)
            {

                Console.Clear();
                int currentPlayer = (turn % 2 == 1) ? 1 : 2;

                for (int i = 0; i < size; i++)
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (pan[i, j] == 1)
                        {
                            Console.Write("● ");
                        }
                        else if (pan[i, j] == 2)
                        {
                            Console.Write("○ ");
                        }
                        else if (pan[i, j] == 0)
                        {
                            Console.Write(". ");
                        }
                        turn++;

                    }
                    Console.WriteLine();
                }

                if (currentPlayer == 1)
                {
                    String[] dot = Console.ReadLine().Split();
                    int a = int.Parse(dot[0]);
                    int b = int.Parse(dot[1]);
                    pan[a, b] = 1;
                    if (pan[a, b] != 0) { Console.WriteLine("이미 돌이 놓인 자리입니다"); }
                }
                else if (currentPlayer == 2)
                {
                    String[] dot = Console.ReadLine().Split();
                    int a = int.Parse(dot[0]);
                    int b = int.Parse(dot[1]);
                    pan[a, b] = 2;
                    if (pan[a, b] != 0) { Console.WriteLine("이미 돌이 놓인 자리입니다"); }
                }



            }



        }
    }
}
