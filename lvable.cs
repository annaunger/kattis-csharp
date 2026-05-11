using System;
class Program
{
    static void Main()
    {
        int wordLength = int.Parse(Console.ReadLine());
        string word = Console.ReadLine();
        
        if (word.Contains("lv"))
        {
            Console.WriteLine(0);
        }
        else if (word.Contains("l"))
        {
            Console.WriteLine(1);
        }
        else if (word.Contains("v"))
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(2);
        }
    }
}