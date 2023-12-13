using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr118_2
{
    class MyClass
    { 
        public int code; 
        public MyClass(int n)
        {
            code = n; 
        }

        public static bool operator true(MyClass obj)
        {
            switch (obj.code)
            {
                case 2:
                case 3:
                case 5:
                case 7:
                    return true;
                default:
                    return false;
            }
        }

        public static bool operator false(MyClass obj)
        {

            if (obj) return obj.code < 1 || obj.code > 10;
            else return true;
        }

        public static MyClass operator &(MyClass a, MyClass b)
        {
            if (a) return b; else return a;
        }

        public static MyClass operator |(MyClass a, MyClass b)
        {
            if (a) return a; else return b;
        }
    }
 
    class Program
    {
        static void Main()
        {
            MyClass A = new MyClass(2);
            MyClass B = new MyClass(6);
            MyClass E = new MyClass(5);
            MyClass Y = new MyClass(12);
            Console.WriteLine("Выражение A&&B: {0}", (A && B).code);
            Console.WriteLine("Выражение B&&A: {0}", (B && A).code);
            Console.WriteLine("Выражение A&&E: {0}", (A && E).code);
            Console.WriteLine("Выражение E&&A: {0}", (E && A).code);
            Console.WriteLine("Выражение A&&Y: {0}", (A && Y).code);
            Console.WriteLine("Выражение Y&&A: {0}", (Y && A).code);
            Console.WriteLine("Выражение A||B: {0}", (A || B).code);
            Console.WriteLine("Выражение В||A: {0}", (B || A).code);
            Console.WriteLine("Выражение A||E: {0}", (A || E).code);
            Console.WriteLine("Выражение E||A: {0}", (E || A).code);
            Console.WriteLine("Выражение А||Y: {0}", (A || Y).code);
            Console.WriteLine("Выражение Y||A: {0}", (Y || A).code);
            Console.ReadLine();
        }
    }
}


