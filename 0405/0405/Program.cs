using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0405
{
    class A
    {
        public String name;
    }
    class B : A
    {
        public B(String name)
        {
            base.name = name;
        }
        public void printName()
        {
            Console.WriteLine(name);
        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            B hr = new B("상속");
            hr.printName();
        }
    }
}
