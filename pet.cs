using System;
class Program
{
    static void Main()
    {
        int highestScore = 0;
        int winner = 0;
        for (int i = 0; i < 5; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            {
                int sum =
                    int.Parse(parts[0]) +
                    int.Parse(parts[1]) +   
                    int.Parse(parts[2]) + 
                    int.Parse(parts[3]);
            if (sum > highestScore)
            {
                highestScore = sum;
                winner = i + 1;
            }
            }
        }
        Console.WriteLine(winner + " " + highestScore);
    }
}