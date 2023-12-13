using System;
class MyClass
{
    private int ass1;
    private int ass2;
    public MyClass(int value1,int value2)
    { 
    ass1 = value1;
    ass2 = value2;
    }
    public static bool operator > (MyClass a, MyClass b)
    {
        int sum1 = a.ass1 * a.ass1 + a.ass2 * a.ass2;
        int sum2 = b.ass1 * b.ass1 + b.ass2 * b.ass2;
        return sum1 > sum2;
    }
    public static bool operator < (MyClass a, MyClass b)
    {
        int sum1 = a.ass1 * a.ass1 + a.ass2 * a.ass2;
        int sum2 = b.ass1 * b.ass1 + b.ass2 * b.ass2;
        return sum1 < sum2;
    }
    public override string ToString()
    {
        return $"Ass1:{ass1},Ass2:{ass2}";
    }
}
class Program
{
    static void Main()
    {
        MyClass a = new MyClass(2, 3);
        MyClass b = new MyClass(4, 5);
        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(a > b);
        Console.WriteLine(a < b);
    }
}