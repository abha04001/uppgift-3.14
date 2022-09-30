using System;

namespace Uppgift_3._14
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Har du gått ut gymnasiet?");
            string svar = Console.ReadLine().ToLower();
            if (svar == "j")
            {
                Console.WriteLine("Du är anställd");
            }
            else if (svar =="n")
            {
                Console.WriteLine("Du är inte anställd");
            }
            else
            {
                Console.WriteLine("Du är anställd om du har gått ut från gymnasiet och är under 22år");
            }
            
        }
    }
}