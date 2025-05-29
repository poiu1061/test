using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumPrac
{
    internal class Program
    {
        enum Size {  Short = 1000, Tall = 2000, Grande= 3000, Venti= 4000};
    
    static void Main(string[] args)
        {
            Size size = Size.Short;
            Console.WriteLine(size);
            Console.WriteLine((int)size);
        }
    }
}
