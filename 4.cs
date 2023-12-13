using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace pr118_1
{
    class MyClass
    { 
        public int code; 
        public string txt; 
        public MyClass(int n, string t)
        {
            code = n; 
            txt = t;  
        }
        public static bool operator <(MyClass a, MyClass b)
        {
            return a.txt.Length < b.txt.Length;
        }
        public static bool operator >(MyClass a, MyClass b)
        {
            return a.txt.Length > b.txt.Length;
        }
        public static bool operator <=(MyClass a, MyClass b)
        {
            if (a.code <= b.code) return true;
            else return false;
        }

        public static bool operator >=(MyClass a, MyClass b)
        {
            if (a.code >= b.code) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return code ^ txt[0];
        }
        public override bool Equals(Object obj)
        {
            MyClass t = (MyClass)obj;
            if (code == t.code && txt == t.txt)
                return true;
            else return false;
        } 
        public static bool operator ==(MyClass a, MyClass b)
        {
            return a.Equals(b);
        }
        public static bool operator !=(MyClass a, MyClass b)
        { 
            return !(a == b);
        }
    }

    class Program
    { 
        static void Main()
        {
            MyClass A = new MyClass(100, "A");
            MyClass B = new MyClass(100, "B");
            MyClass C = new MyClass(200, "A");
            MyClass D = new MyClass(100, "Aaa");
            MyClass E = new MyClass(100, "A");
            Console.WriteLine("A<D дает {0}", A < D);
            Console.WriteLine("A>D дает {0}", A > D);
            Console.WriteLine("A<С дает {0}", A < C);
            Console.WriteLine("A>С дает {0}", A > C);
            Console.WriteLine("А>=C дает {0}", A >= C);
            Console.WriteLine("А<=C дает {0}", A <= B);
            Console.WriteLine("B>=D дает {0}", B >= D);
            Console.WriteLine("B<=D дает {0}", B <= D);
            Console.WriteLine("А==В дает {0}", A == B);
            Console.WriteLine("А!=В дает {0}", A != B);
            Console.WriteLine("А==С дает {0}", A == C);
            Console.WriteLine("А!=С дает {0}", A != C);
            Console.WriteLine("A==D дает {0}", A == D);
            Console.WriteLine("A!=D дает {0}", A != D);
            Console.WriteLine("А==E дает {0}", A == E);
            Console.WriteLine("А!=E дает {0}", A != E);
            Console.ReadLine();
        }
    }
}