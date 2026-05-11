// freeze_year = 2022
// first_line = number of improvements since 2022
// second_line = number of improvements / year
// logic is first_line / second_line + freeze_year

using System;
class Program
{
    static void Main()
    {
        int freeze_year = 2022;
        int first_line = int.Parse(Console.ReadLine());
        int second_line = int.Parse(Console.ReadLine());
        
        Console.WriteLine(first_line / second_line + freeze_year);
    }
}