using System;

class Total
{
    public Total(int i1,int i2)
    {
        Console.WriteLine(i1+i2);
    }
    public Total(double d1,double d2)
    {
        Console.WriteLine(d1+d2);
    }
}

class Program
{
    static void Main()
    {
        int a=10,b=20;
        double c=1.7,d=2.5;
        Total iTo = new Total(a,b);
        Total dTo = new Total(c,d);
    }
}

