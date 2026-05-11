using System;
class Program
{
    static void Main()
    {
        int pizzaSlices = int.Parse(Console.ReadLine());
        int peopleOfHousehold = int.Parse(Console.ReadLine());
        
        Console.WriteLine(pizzaSlices % peopleOfHousehold);
    }
}