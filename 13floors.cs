using System;
class Program
{
    static void Main()
    {
        int input = int.Parse(Console.ReadLine());
        
        if (input < 13)
        {
            Console.WriteLine(input);
        }
        else
        {
            Console.WriteLine(input + 1);
        }
    }
}