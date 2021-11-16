using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quessing Game");
            Random random = new Random();
            int RandomNumber;
            RandomNumber = random.Next(1, 101);
            Console.WriteLine("----------------");
            Console.Write("Tipněte si číslo 1-100: ");
            Console.ReadLine();


        }
    }
}
