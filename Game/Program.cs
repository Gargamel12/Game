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
            int Guess;
            bool neuhodl = true;
            RandomNumber = random.Next(1, 101);
            Console.WriteLine("----------------");
            Console.WriteLine("I think number between 1-101 ");

            while (neuhodl)
            {
                Console.Write("Guess number: ");
                Guess = int.Parse(Console.ReadLine());
                if (Guess > RandomNumber)
                {
                    Console.WriteLine("The number is lower");
                }
                else if (Guess < RandomNumber)
                {
                    Console.WriteLine("The number is bigger");
                }
                else
                {
                    Console.WriteLine("You´ve won");
                    neuhodl = false;
                }
            }
            



        }
    }
}
