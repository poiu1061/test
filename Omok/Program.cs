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
            //오목판의 사이즈 지정
            int size = 15;
            int[,] pan = new int[size, size];
            //플레이어를 구별하기위한 도구
            int turn = 1;



            while (true)
            {
                
                Console.Clear();
                int currentPlayer = (turn % 2 == 1) ? 1 : 2;
                //오목판 만들기
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
                        else
                        {
                            Console.Write(". ");
                        }
                    }
                    Console.WriteLine();
                }


                //currentPlayer의 값으로 흑인지 백인지 차례구하기
                Console.WriteLine(currentPlayer == 1 ? "흑"+"차례" : "백" + "차례");
                string[] dot = Console.ReadLine().Split();
                int a = int.Parse(dot[0]);
                int b = int.Parse(dot[1]);

                //2차원배열에 값넣어 좌표 계산하기
                pan[a, b] = currentPlayer;

                turn++;

            }



        }
    }
}
