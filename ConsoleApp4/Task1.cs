using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        class MyClass
        {
            private int a;
            private int b;
            public MyClass() { a = 7; b = 9; }
            public int C
            {
                get { return a * b; }
                set { }
            }

        }
        static void Main(string[] args)
        {
            MyClass A = new MyClass();
            Console.WriteLine("Property <C> of class <MyClass> is " + A.C + ".");
            Console.ReadKey();
        }
    }
}
