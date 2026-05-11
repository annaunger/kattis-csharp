using System;
class Program
{
    static void Main()
    {
        int minCounter = 100000;
        int t = int.Parse(Console.ReadLine());
        for (int i = 0; i < t; i++)
        {
            int age = int.Parse(Console.ReadLine());
            if (age < minCounter)
            {
                minCounter = age;
            }
        }
        Console.WriteLine(minCounter);
    }
}