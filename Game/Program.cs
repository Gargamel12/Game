using System;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quessing Game");
            Random random = new Random();
            int randomnumber;
            while (true)
            {
                randomnumber = random.Next(1, 5);
                Console.WriteLine(randomnumber);
                Console.ReadLine();
            
            }
        }
    }
}
