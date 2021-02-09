using System;

class IntClass
{
    public int x;
}

class Program
{
    public static void Main()
    {
        IntClass num = new IntClass();
        num.x=int.Parse(Console.ReadLine());
        Console.WriteLine(num.x);
    }
}
