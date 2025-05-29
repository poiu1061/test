using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPrac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("정수 5개를 입력하시오: ");

            //int[] input = new int[5];
            //int sum = 0;
            //for (int i = 0; i < 5; i++)
            //{
            //    String s = Console.ReadLine();
            //    input[i]=int.Parse(s);
            //    sum += input[i];
            //}
            //Console.WriteLine(
            //    "총합: " +sum);

            int[] A = { 3, 1, 4 };
            int[] B = { 6, 2, 5 };

            A.Concat(B);

            Console.WriteLine(String.Join(" ", A.Concat(B).OrderBy(n => n)));
        }

        public void MaxMin()
        {
            Console.WriteLine("정수를 7개 입력하시오");
            String[] s = Console.ReadLine().Split();

            int max = int.Parse(s.Max());
            int min = int.Parse(s.Min());

            Console.WriteLine("최댓값: " + max);
            Console.WriteLine("최소값: " + min);
        }

        public void Reverse()
        {
            String[] s = Console.ReadLine().Split();

            Console.WriteLine(String.Join(" ",s.Reverse()));//배열을 출력하면 system[] 32이런식으로 오류가뜨기때문에 string으로 변환후 출력해준다.
        }

        public void SameErase()
        {
            String[] input = Console.ReadLine().Split();
            int[] num = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                num[i] = int.Parse(input[i]);          
            }
            Console.WriteLine(String.Join(" ", num.Distinct()));
        }

        public void frequency()
        {
            String[] input = Console.ReadLine().Split();
            int[] num = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                num[i] = int.Parse(input[i]);
            }
            foreach (int value in num.Distinct()) //distinct는 배열의 중복값을 제거해준다.
            {
                int freq = num.Count(n => n == value); //람다식으로 표현되어잇다 임의의 변수 n을 정의하여 중복값을 제거한 배열의 value를 넣어 계산한다
                Console.WriteLine($"{value}는 {freq}번 등장합니다");
            }

        }

        public void CombineArray()
        {
            int[] A = { 3, 1, 4 };
            int[] B = { 6, 2, 5 };

            A.Concat(B);//concat은 배열을 서로 합쳐준다. 그런다고해서 A가 영향을 받는게 아니기때문에 합친 값을 저장하고싶으면 새로 배열을 만들어야한다

            Console.WriteLine(String.Join(" ",A.Concat(B).OrderBy(n=>n))); 
        }

        public
    }
}
