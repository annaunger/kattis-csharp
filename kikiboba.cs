using System;
namespace KikiBoba
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            int kCounter = 0;
            int bCounter = 0;
            foreach (char character in word)
            {
                if (character == 'k')
                {
                    kCounter++;
                }
                else if (character == 'b')
                {
                    bCounter++;
                }
            }
            if (kCounter > bCounter)
            {
                Console.WriteLine("kiki");
            }
            else if (kCounter < bCounter)
            {
                Console.WriteLine("boba");
            }
            else if (kCounter == 0 && bCounter == 0)
            {
                Console.WriteLine("none");
            }
            else 
            {
                Console.WriteLine("boki");
            }
        }
    }
}