using System;
class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        double qaly = 0;
        for (int i = 0; i < t; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            double q = double.Parse(parts[0]);
            double y = double.Parse(parts[1]);
            
            double qualityOfPeriod = q * y;
            
            qaly += qualityOfPeriod;
        }
        Console.WriteLine(qaly);
    }
}