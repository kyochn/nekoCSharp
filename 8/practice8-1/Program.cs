using System;

class Myclass
{
    double b1;
    public double MyPro
    {
        get
        {
            return b1;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("入力できるのは正の数のみです");
                return;
            }
            b1 = value;
        }
    }
}

class Program
{
    public static void Main()
    {
        Console.Write("正の整数を入力：");
        Myclass mc = new Myclass();
        do
        {
            mc.MyPro = double.Parse(Console.ReadLine());
        } while (mc.MyPro <= 0);
        Console.WriteLine("入力した数：{0}", mc.MyPro);
    }
}
