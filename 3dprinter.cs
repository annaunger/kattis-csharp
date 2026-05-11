using System;
class Program
{
    static void Main()
    {
        int days = 0;
        int printers = 1;
        int t = int.Parse(Console.ReadLine());
        
        
        while (printers < t)
        {
            printers *= 2;
            days++;
        }
            
        
        days++;
            
        Console.WriteLine(days);
        
    }
}