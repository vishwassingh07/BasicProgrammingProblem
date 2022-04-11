using BasicProgrammingProb;
using System;
namespace BasicProgrammingProb
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Basic Programming Problems");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. End the Program ");
            while (end)
            {
                Console.WriteLine("Choose an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoin flipcoin = new FlipCoin();
                        flipcoin.Flip();
                        break;
                    case 2:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Choose the correct option");
                        break;
                }
            }

        }

    }
}