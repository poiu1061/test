using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPrac
{
    enum Weather { sunny, cloudy, rainy }
    enum Day { Monday,tuesday,Wednesday,Thursday,Friday,Saturday,Sunday}

    enum Menu { Americano = 1,Latte = 2, Mocha = 3}
    internal class Class1
    {
        public void day()
        {
            Weather weather = Weather.rainy;
            if (weather == Weather.sunny)
            {
                Console.WriteLine("비가 오니 우산 챙기세요");
            }
        }

        public void day2()
        {
            Day day = Day.Saturday;

            if(day == Day.Saturday || day == Day.Sunday)
            {
                Console.WriteLine("휴일입니다"); 
            }
            else
            {
                Console.WriteLine("휴일이 아닙니다");
            }
        }

        public void Caffe()
        {
            int s = int.Parse(Console.ReadLine());

            switch (s)
            {
                case 1: Console.WriteLine("당신은 {0}을 선택했습니다", Menu.Americano);
                    break;
                case 2: Console.WriteLine("당신은 {0}을 선택했습니다", Menu.Latte);
                    break;
                case 3:
                    Console.WriteLine("당신은 {0}을 선택했습니다", Menu.Mocha);
                    break;
            }

        }

        enum DayOfWeek { Monday = 1, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

       
        }

}
