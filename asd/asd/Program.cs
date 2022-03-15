using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asd
{
    class Program
    {
        static void Main(string[] args)
        {
            int year = int.Parse(Console.ReadLine());
            if (year < 1 || year > 4000) return;

            if (year % 4 == 0 && year % 100 != 0)
            {
                Console.WriteLine("윤년입니다.");
            }
           
            else
            {
                Console.WriteLine("윤년이아닙니다");
            }
        }
    }
}