using System;
class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        string previous = Console.ReadLine();
        int hungoverCounter = 0;
        
        for (int i = 0; i < t; i++)
        {
            string current = Console.ReadLine();
            
            if (previous == "drunk" && current == "sober")
            {
                hungoverCounter++;
            }
            previous = current;
        }
        Console.WriteLine(hungoverCounter);
    }
}
