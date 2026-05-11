using System;

namespace ConcatenateLinesOfCode

{
    class Program 
    {
      static void Main(string[] args)  
      {
          string firstLineOfCode = Console.ReadLine();
          string secondLineOfCode = Console.ReadLine();
          string singleLineCode = firstLineOfCode + secondLineOfCode;
          Console.WriteLine(singleLineCode);
      }
    }
}