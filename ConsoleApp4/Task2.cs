using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class A
        {
            private int a;
            private int b;
            public A() { a = 3; b = 4; }
            public A(int A, int B) { a = A; b = B; }
            public int C1
            {
                get { return a * b; }
            }
        }
        class B : A
        {
            private int d;
            public B(int D) { d = D; }
            public B(int A, int B, int D) : base(A, B) { d = D; }
            public int C2
            {
                get { return C1 - d; }
                set { d = value; }
            }
        }

        static void Main(string[] args)
        {
            //class A objects
            A a1 = new A();
            Console.WriteLine("Property C1 of object a1 is " + a1.C1 + ".");
            A a2 = new A(10, 15);
            Console.WriteLine("Property C1 of object a1 is " + a2.C1 + ".");
            //class B objects
            B b1 = new B(4);
            Console.WriteLine("Property C2 of object b1 is " + b1.C2 + ".");
            B b2 = new B(5, 6, 7);
            Console.WriteLine("Property C2 of object b2 is " + b2.C2 + ".");
            Console.ReadKey();
        }
    }
}


