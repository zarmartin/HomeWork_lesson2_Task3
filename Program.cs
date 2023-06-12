using System;

namespace Task3
{
    class Program
    {
        static public void Main()
        {
            Console.WriteLine("Specify the direction of movement:");
            Console.WriteLine($"Choose \"w\" to move up!");
            Console.WriteLine($"Choose \"s\" to move down!");
            Console.WriteLine($"Choose \"a\" to move left!");
            Console.WriteLine($"Choose \"d\" to move right!");
            var input = Console.ReadLine();
            switch (input)
            {
                case "w":
                    Console.WriteLine("You move up!");
                    break;
                case "s":
                    Console.WriteLine("You move down!");
                    break ;
                case "a":
                    Console.WriteLine("You move left!");
                    break;
                case "d":
                    Console.WriteLine("You move right!");
                    break;
                default:
                    Console.WriteLine("I don't know this command!");
                    break;
            }
        }
    }
}
