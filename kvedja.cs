using System;
namespace EmailSignature

{
    class Program
    {
        static void Main(string[] args)
        {
            string senderName = Console.ReadLine();
            string emailSignature = String.Format("Kvedja, \n" + senderName);
            Console.WriteLine(emailSignature);
        }
    }
}