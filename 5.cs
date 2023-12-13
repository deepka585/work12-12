class MyClass
{
    public int code;
    public char sym;
    public MyClass(int a, char b)
    {
        code = a;
        sym = b;
    }

    public MyClass(int a)
    {
        code = a;
        sym = (char)a;
    }

    public MyClass(char b)
    {
        code = (int)b;
        sym = b;
    }
    public static bool operator true(MyClass obj)
    {
        if (obj.code - (int)obj.sym <= 10 || obj.code - (int)obj.sym >= -10) return true;
        else return false;
    }

    public static bool operator false(MyClass obj)
    {
        if (obj) return false;
        else return true;
    }

    public override string ToString()
    {
        string txt = sym + "(" + code + ")" + " ";
        return txt;
    }
}
class Program
{
    static void Main(string[] args)
    {
        char[] array = new char[] { 'A', 'b', 'D', 'e', 'X', 'I', 'R', 'O', 'k', 'w', 'q', 'L', 'U', 'p', 'F' };
        Console.WriteLine("Введите контрольный символ");
        MyClass A = new MyClass(Console.Read());
        Console.WriteLine();
        Console.WriteLine(A);

        for (int i = 0; i < array.Length; i++)
        {
            A.sym = array[i];
            if (A) Console.Write(array[i] + "(" + (int)array[i] + ")" + " ");
        }
    }
}