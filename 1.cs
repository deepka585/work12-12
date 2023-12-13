using System;
class SymbolClass
{
    private char symbol;
    public SymbolClass(char symbol)
    { this.symbol = symbol;
    }
    public static SymbolClass operator ++ (SymbolClass obj)
    {
        obj.symbol = (char) (obj.symbol + 1);
        return obj;
    }
    public static SymbolClass operator -- (SymbolClass obj)
    {
        obj.symbol = (char)(obj.symbol - 1);
        return obj;
    }
    public static SymbolClass operator + (SymbolClass obj, int number)
    {
        return new SymbolClass((char)(obj.symbol + number));
    }
    public static SymbolClass operator + (int number, SymbolClass obj)
    {
        return new SymbolClass((char) (obj.symbol + number));
    }
    public static int operator-(SymbolClass obj1,SymbolClass obj2)
    {
        return obj1.symbol - obj2.symbol;
    }
    public override string ToString()
    {
        return symbol.ToString();
    }
}
class Program
{
    static void Main()
    {
        SymbolClass obj1 = new SymbolClass('a');
        SymbolClass obj2 = new SymbolClass('b');
        Console.WriteLine(obj1);
        Console.WriteLine(obj2);
        obj1++;
        obj2--;
        Console.WriteLine(obj1);
        Console.WriteLine(obj2);
        SymbolClass obj3 = obj1 + 1;
        SymbolClass obj4 = 2 + obj2;
        Console.WriteLine(obj3);
        Console.WriteLine(obj4);
        int diff = obj3 - obj4;
        Console.WriteLine(diff);
    }
}