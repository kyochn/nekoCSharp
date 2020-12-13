using System;

class practice6_1
{
    public static void Main()
    {
        int usernum=int.Parse(Console.ReadLine());
        double[] point = new double[usernum];
        
        for(int i=0;i<point.Length;i++)
        {
            point[i]=int.Parse(Console.ReadLine());
        }
        Console.WriteLine();
        
        double ave=0.0;
        foreach(float i in point) ave+=i;
        Console.WriteLine(ave/usernum);
        Console.WriteLine();

        Array.Sort(point);
        Array.Reverse(point);
        
        foreach(int i in point)
        {
            Console.WriteLine(i);
        }
    }
}
