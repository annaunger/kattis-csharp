using System;
class Program
{
    static void Main()
    {
        int firstLine = int.Parse(Console.ReadLine());
        int secondLine = int.Parse(Console.ReadLine());
        int thirdLine = int.Parse(Console.ReadLine());
            
        int parkingTime = firstLine * thirdLine;
            
        Console.WriteLine(parkingTime);
    }
}