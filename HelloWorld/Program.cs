using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mis su nimi on?");
            string UserName;
            UserName = Console.ReadLine();

            Console.WriteLine("Tere, " + UserName);

            Console.Read();

          
        }
    }
}
