using System;
using System.Collections.Generic;

class Alphabet
{
    public static void Main()
    {
        Dictionary<char, string> sub = new Dictionary<char, string>();
        
        sub.Add('a', "@");
        sub.Add('b', "8");
        sub.Add('c', "(");
        sub.Add('d', "|)");
        sub.Add('e', "3");
        sub.Add('f', "#");
        sub.Add('g', "6");
        sub.Add('h', "[-]");
        sub.Add('i', "|");
        sub.Add('j', "_|");
        sub.Add('k', "|<");
        sub.Add('l', "1");
        sub.Add('m', @"[]\/[]");
        sub.Add('n', @"[]\[]");
        sub.Add('o', "0");
        sub.Add('p', "|D");
        sub.Add('q', "(,)");
        sub.Add('r', "|Z");
        sub.Add('s', "$");
        sub.Add('t', "']['");
        sub.Add('u', "|_|");
        sub.Add('v', @"\/");
        sub.Add('w', @"\/\/");
        sub.Add('x', "}{");
        sub.Add('y', "`/");
        sub.Add('z', "2");
    
        string input = Console.ReadLine();
        
        foreach (char character in input)
        {
            char lower = char.ToLower(character);
            if (sub.ContainsKey(lower))
            {
                Console.Write(sub[lower]);
            }
            else
            {
                Console.Write(character);
            }
        }
        
    }
}