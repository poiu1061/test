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
            int[,] black = new int[size, size];
            int[,] white = new int[size, size];

            int turn = 1;

            while (true)
            {

                Console.Clear();
                int currentPlayer = (turn % 2 == 1) ? 1 : 2;
                //오목판 만들기
                Console.WriteLine("  0 1 2 3 4 5 6 7 8 9 1011121314");
                for (int i = 0; i < size; i++)
                {
                    if (i < 10)
                        Console.Write(i + " ");
                    else
                        Console.Write(i);
                    for (int j = 0; j < size; j++)
                    {

                        if (pan[i, j] == 1)
                        {
                            Console.Write("○ ");
                        }
                        else if (pan[i, j] == 2)
                        {
                            Console.Write("● ");
                        }
                        else
                        {
                            Console.Write(". ");
                        }
                    }
                    Console.WriteLine();
                }

                //currentPlayer의 값으로 흑인지 백인지 차례구하기
                Console.WriteLine(currentPlayer == 1 ? "흑" + "차례" : "백" + "차례");
                string[] dot = Console.ReadLine().Split();
                int a = int.Parse(dot[0]);
                int b = int.Parse(dot[1]);

                //중복값 막기
                if (pan[a, b] != 0)
                {
                    Console.WriteLine("이미 돌이 놓인 자리입니다.");
                    Console.ReadKey();
                    continue;
                }
                //2차원배열에 값넣어 좌표 계산하기
                pan[a, b] = currentPlayer;


                //가로 이동 b
                for (int i = 0; i < size; i++)
                {
                    int count = 1;
                    for (int j = 1; j < size; j++)
                    {
                        if (pan[i, j] != 0 && pan[i, j] == pan[i, j - 1])
                        {
                            count++;
                        }
                        else
                        {
                            count = 1;
                        }

                        if (count == 5)
                        {
                            Console.WriteLine("You Win!");
                            return;
                        }
                    }
                }

                //세로 이동 a
                for (int i = 0; i < size; i++)
                {
                    int count = 1;
                    for (int j = 1; j < size; j++)
                    {
                        if (pan[j, i] != 0 && pan[j, i] == pan[j - 1, i])
                        {
                            count++;
                        }
                        else
                        {
                            count = 1;
                        }

                        if (count == 5)
                        {
                            Console.WriteLine("You Win!");
                            return;
                        }
                    }
                }
                //우하향 대각선 +b +a
                for (int i = 0; i <= size - 5; i++)
                {
                    for (int j = 0; j <= size - 5; j++)
                    {
                        int count = 1;
                        for (int k = 1; k < 5; k++)
                        {
                            if (pan[i + k, j + k] != 0 && pan[i + k, j + k] == pan[i + k - 1, j + k - 1])
                            {
                                count++;
                                if (count == 5)
                                {
                                    Console.WriteLine("You Win!");
                                    return;
                                }
                            }
                            else
                            {
                                break; // 연속이 끊기면 바로 for 루프 탈출
                            }
                        }
                    }
                }

                //하 대각선 -b +a
                turn++;
            }
        }


    }
}
