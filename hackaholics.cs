using System;
class Program
{
    static void Main()
    {
        int firstLine = int.Parse(Console.ReadLine());
        int secondtLine = int.Parse(Console.ReadLine());
        int thirdLine = int.Parse(Console.ReadLine());
        
        int expectedPriceValue = firstLine * thirdLine;
        
        Console.WriteLine(expectedPriceValue);
    }
}