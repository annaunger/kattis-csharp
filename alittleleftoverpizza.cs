using System;
class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        
        int sCounter = 0; 
        int mCounter = 0; 
        int lCounter = 0; 
        
        for (int i = 0; i < t; i++)
        {
            string[] parts = Console.ReadLine().Split(' ');
            
            char size = char.Parse(parts[0]);
            int slices = int.Parse(parts[1]);
            
            if (size == 'S')
            {
                sCounter += slices;
            }
            else if (size == 'M')
            {
                mCounter += slices;
            }
            else if (size == 'L')
            {
                lCounter += slices;
            }
            
        }
        int boxS = (sCounter + 5) / 6;
        int boxM = (mCounter + 7) / 8;
        int boxL = (lCounter + 11) / 12;
        Console.WriteLine(boxS + boxM + boxL);
    }
}